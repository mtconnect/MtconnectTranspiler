using ConsoulLibrary;
using ConsoulLibrary.Views;
using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi;
using System.Threading;

namespace MtconnectTranspiler.Console.Views
{
    internal class MainView : StaticView
    {
        private ILogger<TranspilerDispatcher> _logger;

        public MainView()
        {
            Title = (new BannerEntry($"MTConnect Transpiler")).Message;

            // Uses Microsoft.Extensions.Logging for the LoggerFactory and ILogger
            // Uses the Consoul library for color formatting
            _logger = LoggerFactory.Create((o) => o.AddConsoulLogger()).CreateLogger<TranspilerDispatcher>();
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
        }

        private async void Deserialize(TranspilerDispatcherOptions options)
        {
            using (var cancellationSource = new CancellationTokenSource())
            {
                var deserializer = options.GetDeserializer();

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
        }
        private async void Deserialize(XmiDeserializer deserializer, CancellationToken cancellationToken)
        {
            Consoul.Write("Deserializing...");
            XmiDocument? model = deserializer.Deserialize(cancellationToken);

            Consoul.Write("Finished deserializing");
        }
    }
}
