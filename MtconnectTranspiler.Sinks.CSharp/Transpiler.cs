using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System.Data;

namespace MtconnectTranspiler.Sinks.CSharp
{
    public class IncludeSharedTemplates : ITemplateLoader
    {
        public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
        {
            return Path.Combine("Templates", templateName);
        }

        public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return File.ReadAllText(templatePath);
        }

        public async ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            var mtconnectFunctions = new MTConnectHelperMethods();
            context.PushGlobal(mtconnectFunctions);
            return await File.ReadAllTextAsync(templatePath);
        }
    }
    public class Transpiler : ITranspilerSink
    {
        /// <summary>
        /// The root output directory for the transpiled code.
        /// </summary>
        public string ProjectPath { get; set; }

        private TemplateContext TemplateContext { get; set; }
        private ScriptObject Model { get; set; }

        public Transpiler(string projectPath)
        {
            ProjectPath = projectPath;

            TemplateContext = new TemplateContext();
            TemplateContext.TemplateLoader = new IncludeSharedTemplates();

            var helperFunctions = new ScribanHelperMethods();
            TemplateContext.PushGlobal(helperFunctions);

            var mtconnectFunctions = new MTConnectHelperMethods();
            TemplateContext.PushGlobal(mtconnectFunctions);


            Model = new ScriptObject();
            TemplateContext.PushGlobal(Model);
        }

        /// <inheritdoc />
        public Task<string> Transpile(MTConnectModel model)
        {
            Model.SetValue("model", model, true);
            Model.SetValue("version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString(), true);

            // Process Enums
            processTemplate(
                model?.Profile?.ProfileDataTypes?.Elements?.Where(o => o is UmlEnumeration),
                getTemplate(@"Templates\Enum.scriban"),
                Path.Combine(ProjectPath, "Contracts", "Enums"),
                "enumeration",
                o => o.Name + ".cs"
            );

            processDeviceModel(model.DeviceModel, getTemplate(@"Templates\Class.scriban"));

            return Task.FromResult("");
        }

        private void processDeviceModel(MTConnectDeviceInformationModel model, Template classTemplate, string @namespace = "MtconnectCore.Standard")
        {
            if (model == null) return;

            if (model.Classes != null && model.Classes.Any())
            {
                processTemplate(
                    model.Classes.Select(o => new { @Class = o, Namespace = $"{@namespace}.{o.Name}" }),
                    classTemplate,
                    Path.Combine(ProjectPath, "Standard", model.Name),
                    "class_model",
                    o => $"{o.Class.Name}.cs"
                );
            }

            if (model.SubModels != null && model.SubModels.Any())
            {
                // Recursively build sub-class structure
                foreach (var subModel in model.SubModels)
                {
                    processDeviceModel(subModel, classTemplate, $"{@namespace}.{model.Name}");
                }
            }
        }

        private Template getTemplate(string filepath)
        {
            string templateContent = File.ReadAllText(filepath);
            var template = Template.Parse(templateContent);
            
            return template;
        }
        private string renderTemplateWithModel(string modelName, object model, Template template)
        {
            if (model == null) return String.Empty;

            Model.SetValue(modelName, model, true);
            string csharp = template.Render(TemplateContext);

            Model.Remove(modelName);

            return csharp;
        }
        private void processTemplate<T>(IEnumerable<T>? items, Template template, string folderPath, string modelName, Func<T, string> filenameGenerator)
        {
            if (modelName.Equals("model", StringComparison.OrdinalIgnoreCase))
                throw new DuplicateNameException("Scriban Template Context already has a member name 'model' associated with the context.");

            if (items == null || items.Any() == false) return;

            foreach (var item in items)
            {
                string csharp = renderTemplateWithModel(modelName, item, template);
                XmiTranspilerExtensions.WriteToFile(Path.Combine(folderPath, filenameGenerator(item)), csharp);
            }
        }
    }

}