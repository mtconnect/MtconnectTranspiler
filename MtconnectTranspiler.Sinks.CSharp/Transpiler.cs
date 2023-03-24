using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System.Data;
using System.Reflection;

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
                model?.Profile?.ProfileDataTypes?.Elements
                ?.Where(o => o is UmlEnumeration)
                ?.Select(o => new Models.Enum(model, o as UmlEnumeration)),
                Path.Combine(ProjectPath, "Enums"));

            processDeviceModel(model.DeviceModel);

            return Task.FromResult("");
        }

        private void processDeviceModel(MTConnectDeviceInformationModel model, string @namespace = "MtconnectCore.Standard")
        {
            if (model == null) return;

            if (model.Classes != null && model.Classes.Any())
            {
                processTemplate(
                    model.Classes.Select(o => new Class(Model["model"] as MTConnectModel, o) { Namespace = $"{@namespace}.{o.Name}" }),
                    ProjectPath//Path.Combine(ProjectPath, value.Name),
                );
            }

            if (model.SubModels != null && model.SubModels.Any())
            {
                // Recursively build sub-class structure
                foreach (var subModel in model.SubModels)
                {
                    if (subModel.Name == "Component Types")
                    {
                        // Convert Component Classes into Enums
                        // Process Enums
                        processTemplate(
                            new Models.Enum(Model["model"] as MTConnectModel, subModel),
                            Path.Combine(ProjectPath, "Enums"));
                    } else
                    {
                        processDeviceModel(subModel, $"{@namespace}.{model.Name}");
                    }
                }
            }
        }

        private Dictionary<string, Template> templateCache = new Dictionary<string, Template>();
        private Template getTemplate(string filepath)
        {
            if (templateCache.TryGetValue(filepath, out Template template)) return template;

            string templateContent = File.ReadAllText(filepath);
            template = Template.Parse(templateContent);

            if (template != null && templateCache.TryAdd(filepath, template))
            {
                return template;
            }

            throw new InvalidOperationException();
        }
        private string renderTemplateWithModel(string member, object value, Template template)
        {
            if (value == null) return String.Empty;
            if (Model.Contains(member))
            {
                Model.Remove(member);
            }
            Model.SetValue(member, value, true);
            string csharp = template.Render(TemplateContext);

            Model.Remove(member);

            return csharp;
        }
        private void processTemplate<T>(IEnumerable<T>? items, string folderPath) where T : IFileSource
        {
            if (items == null || items.Any() == false) return;

            foreach (var item in items) processTemplate(item, folderPath);
        }
        private void processTemplate<T>(T? item, string folderPath) where T : IFileSource
        {
            if (item == null) return;

            System.Type type = typeof(T);
            ScribanTemplateAttribute attr = type.GetCustomAttribute<ScribanTemplateAttribute>();

            Template template = getTemplate($"Templates\\{attr.Filename}");
            if (template == null)
            {
                throw new FileNotFoundException();
            }

            string csharp = renderTemplateWithModel("source", item, template);
            XmiTranspilerExtensions.WriteToFile(Path.Combine(folderPath, item.Filename), csharp);
        }
    }

}