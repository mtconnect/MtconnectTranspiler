﻿using ConsoulLibrary;
using ConsoulLibrary.Views;
using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Interpreters;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.XmiOptions;
using System.Text;
using System.Threading;

namespace MtconnectTranspiler.Console.Views
{
    internal class MainView : StaticView
    {
        private ILogger<XmiDeserializer> _logger;

        public MainView()
        {
            Title = (new BannerEntry($"MTConnect Transpiler")).Message;

            // Uses Microsoft.Extensions.Logging for the LoggerFactory and ILogger
            // Uses the Consoul library for color formatting
            _logger = LoggerFactory.Create((o) => o.AddConsoulLogger()).CreateLogger<XmiDeserializer>();
        }

        [ViewOption("Transpile From GitHub Latest")]
        public void TranspileFromGitHub()
        {
            var options = new FromGitHubOptions() { GitHubRelease = "latest" };
            if (!Consoul.Ask("Would you like to use the latest GitHub Release of mtconnect_sysml_model?", allowEmpty: true, defaultIsNo: false))
            {
                string release = Consoul.Input("Please specify which Release you would prefer to use");
                options.GitHubRelease = release;
            }

            Deserialize(options);
        }

        [ViewOption("Transpile From File")]
        public void TranspileFromFile()
        {
            var options = new FromFileOptions();
            options.Filepath = Consoul.PromptForFilepath("Please provide the filepath to the copy of the mtconnect_sysml_model XMI", true);

            Deserialize(options);
            Consoul.Wait();
        }

        [ViewOption("Transpile From model.MTConnect.org")]
        public void TranspileFromMtconnectOrg()
        {
            var options = new FromMtconnectOrg();

            Deserialize(options);
            Consoul.Wait();
        }

        [ViewOption("Test Markdown Interpreter")]
        public void TestMarkdownInterpreter()
        {
            string[] interpreterOptions = new string[]
            {
                typeof(CustomDslInterpreter)!.FullName!,
                typeof(HtmlInterpreter)!.FullName!,
                typeof(JavadocInterpreter)!.FullName!,
                typeof(MediaWikiInterpreter)!.FullName!,
                typeof(OpenDocumentTextInterpreter)!.FullName!,
                typeof(PdfInterpreter)!.FullName!,
                typeof(PlainTextInterpreter)!.FullName!,
                typeof(RSTInterpreter)!.FullName!,
                typeof(RtfInterpreter)!.FullName!,
                typeof(SwaggerInterpreter)!.FullName!,
                typeof(VisualStudioSummaryInterpreter)!.FullName!,
                typeof(YamlInterpreter)!.FullName!
            };
            var chooseInterpreter = new Prompt("Choose an interpreter", true, interpreterOptions);
            var interpreterName = interpreterOptions[chooseInterpreter.Run()];
            var assembly = typeof(MarkdownInterpreter).Assembly;

            var instance = Activator.CreateInstance(assembly.GetType(interpreterName)!) as MarkdownInterpreter;

            var options = new FromGitHubOptions() { GitHubRelease = "latest" };
            Consoul.Write("Getting model from GitHub...", ConsoleColor.Yellow, false);
            var deserializer = options.GetDeserializer();
            Consoul.Write("Done!", ConsoleColor.Green);
            Consoul.Write("Deserializing XMI...", ConsoleColor.Yellow);
            var result = deserializer.Deserialize(default);
            Consoul.Write("Done!", ConsoleColor.Green);

            var path = MTConnectHelper.PackageNavigationTree.ObservationInformationModel.ObservationTypes.EventTypes;
            Consoul.Write("Path: " + path);
            var package = MTConnectHelper.JumpToPackage(result!, path);

            StringBuilder sb = new StringBuilder();
            Consoul.Write("Interpreting...", ConsoleColor.Yellow, false);
            foreach (var item in package!.Classes!)
            {
                foreach (var comment in item!.Comments!)
                {
                    sb.AppendLine(instance!.Interpret(comment));
                }
            }
            Consoul.Write("Done!", ConsoleColor.Green);

            if (Consoul.Ask("Would you like to save the output?"))
            {
                string filepath = Consoul.PromptForFilepath("Enter filepath", false);
                Consoul.Write("Writing...", ConsoleColor.Yellow, false);
                File.WriteAllText(filepath, sb.ToString(), Encoding.UTF8);
                Consoul.Write("Done!", ConsoleColor.Green);
                Consoul.Write("Saved to\r\n\t" + filepath);
                Consoul.Write("Filepath saved to clipboard!", ConsoleColor.Gray);
                TextCopy.ClipboardService.SetText(filepath);
            }

            Consoul.Wait();
        }

        [ViewOption("Build Navigation Structure")]
        public void TranspilePackageNavigation()
        {
            XmiDeserializer? deserializer = null;
            if (Consoul.Ask("Would you like to use GitHub's latest version?"))
            {
                var options = new FromGitHubOptions() { GitHubRelease = "latest" };
                deserializer = options.GetDeserializer();
            } else
            {
                var options = new FromFileOptions() { Filepath = Consoul.PromptForFilepath("Please enter path for SysML model", true) };
                deserializer = options.GetDeserializer();
            }

            var result = deserializer.Deserialize(default);
            StringBuilder sb = new();

            var profile = result!.Model!.Profiles!.FirstOrDefault()!;
            sb.AppendLine(BuildNavigationClass(null, profile, profile.Packages));

            sb.AppendLine(BuildNavigationStructure(result.Model.Packages));

            string output = sb.ToString();
            TextCopy.ClipboardService.SetText(output);

            Consoul.Write("Copied C# to your clipboard", ConsoleColor.Gray);
            Consoul.Wait();
        }

        [ViewOption("Test Navigational Tree")]
        public void TestNavigationalTree()
        {
            var options = new FromGitHubOptions() { GitHubRelease = "latest" };

            var deserializer = options.GetDeserializer();
            var result = deserializer.Deserialize(default);

            var path = MTConnectHelper.PackageNavigationTree.ObservationInformationModel.ObservationTypes.SampleTypes;
            Consoul.Write("Path: " + path);
            var package = MTConnectHelper.JumpToPackage(result!, path);
            var type = package!.Classes!.FirstOrDefault();
            var units = type!.Properties!.FirstOrDefault(o => o.Name == "units");
            var defaultValue = units!.DefaultValue;
            Consoul.Write("Package ID: " + (package?.Id ?? "Not found"));
            Consoul.Wait();
        }

        private static string BuildNavigationStructure(PackagedElementCollection<UmlPackage>? packages, PackagedElement? parent = null)
        {
            if (packages == null)
                throw new ArgumentNullException(nameof(packages));
            StringBuilder sb = new();

            foreach (var package in packages)
            {
                if (package!.Packages!.Count > 0)
                {
                    sb.AppendLine(BuildNavigationClass(parent, package, package.Packages));
                } else
                {
                    sb.AppendLine(BuildNavigationItem(package, parent != null));
                }
            }

            return sb.ToString();
        }

        private static string BuildNavigationClass(PackagedElement? parent, PackagedElement? package, PackagedElementCollection<UmlPackage>? children)
        {
            if (package == null || string.IsNullOrEmpty(package.Name))
                throw new ArgumentNullException(nameof(package));

            string? csharpName = ToCSharp(package.Name);
            string? csharpParentName = ToCSharp(parent?.Name);

            StringBuilder sb = new();
            sb.AppendLine($"private {csharpName}Navigation? _{csharpName};");
            sb.AppendLine($"/// <summary>");
            sb.AppendLine($"/// <inheritdoc cref=\"{csharpName}\" /> to <c>{package.Name}</c>");
            sb.AppendLine($"/// </summary>");
            sb.Append($"public {csharpName}Navigation {csharpName} => _{csharpName} ??= new {csharpName}Navigation(");
            if (parent != null)
                sb.Append("this");
            sb.AppendLine(");");

            sb.AppendLine($"/// <summary>");
            sb.AppendLine($"/// <inheritdoc cref=\"NavigationItem\" /> to <c>{package.Name}</c>");
            sb.AppendLine($"/// </summary>");
            sb.AppendLine($"public class {csharpName}Navigation : NavigationItem");
            sb.AppendLine($"{{");

            sb.AppendLine(BuildNavigationStructure(children, package));

            sb.AppendLine($"/// <summary>");
            sb.AppendLine($"/// Constructs a new <see cref=\"{csharpName}Navigation\" /> navigation tree.");
            sb.AppendLine($"/// </summary>");
            if (parent != null)
                sb.AppendLine($"/// <param name=\"parent\">Reference to the parent branch <see cref=\"{csharpParentName}Navigation\"/></param>");
            sb.Append($"public {csharpName}Navigation(");
            if (parent != null)
                sb.Append($"{csharpParentName}Navigation parent");
            sb.Append($") : base(\"{package.Name}\"");
            if (parent != null)
                sb.Append($", parent");
            sb.AppendLine($") {{ }}");

            sb.AppendLine($"}}");

            return sb.ToString();
        }

        private static string? ToCSharp(string? input)
        {
            return input
                ?.Replace(" ", string.Empty)
                ?.Replace("/", string.Empty)
                ?.Replace("-", string.Empty)
                ?.Replace(":", string.Empty);
        }
        private static string BuildNavigationItem(PackagedElement? package, bool hasParent)
        {
            if (package == null || string.IsNullOrEmpty(package.Name))
                throw new ArgumentNullException(nameof(package));

            string? csharpName = ToCSharp(package.Name);

            StringBuilder sb = new();
            sb.AppendLine($"private NavigationItem? _{csharpName};");
            sb.AppendLine($"/// <summary>");
            sb.AppendLine($"/// <inheritdoc cref=\"NavigationItem\" /> to <c>{package.Name}</c>");
            sb.AppendLine($"/// </summary>");
            sb.Append($"public NavigationItem {csharpName} => _{csharpName} ??= ");
            if (hasParent)
                sb.Append($"(this, ");
            sb.Append($"\"{package.Name}\"");
            if (hasParent)
                sb.Append(")");
            sb.AppendLine(";");
            sb.AppendLine();
            return sb.ToString();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async void Deserialize(TranspilerDispatcherOptions options)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            using var cancellationSource = new CancellationTokenSource();
            var deserializer = options.GetDeserializer(_logger);

            var task = Task.Run(() => Deserialize(deserializer, cancellationSource.Token)).ContinueWith((t) => cancellationSource.Cancel());

            // We'll leverage Consoul to help make this pretty. The ContinueWith above helps make sure the Consoul.Wait goes away when the task is done.
            Consoul.Wait(cancellationToken: cancellationSource.Token);

            if (task.IsCompletedSuccessfully)
            {
                Consoul.Write("Success!", ConsoleColor.Green);
            }
            else
            {
                Consoul.Write("Aborted!", ConsoleColor.Red);
            }
        }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async void Deserialize(XmiDeserializer deserializer, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            Consoul.Write("Deserializing...");
            XmiDocument? model = deserializer.Deserialize(cancellationToken);

            Consoul.Write("Finished deserializing");
        }
    }
}
