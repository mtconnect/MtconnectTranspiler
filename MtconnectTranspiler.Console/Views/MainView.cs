using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoulLibrary;
using ConsoulLibrary.Views;
using MtconnectTranspiler;

namespace MtconnectTranspiler.Console.Views
{
    internal class MainView : StaticView
    {
        public MainView()
        {
            Title = (new BannerEntry($"MTConnect Transpiler")).Message;
        }

        [ViewOption("Transpile to C#")]
        public void TranspileToCSharp()
        {
            string projectPath = Consoul.PromptForFilepath("Provide a project folder path", true);
            string xmiPath = Consoul.PromptForFilepath("Provide the path to the MTConnect SysML Model", true);
            var options = new TranspilerOptions();
            options.Transpilers.Add(new MtconnectTranspiler.Sinks.CSharp.Transpiler(Path.Combine(projectPath, "CSharp")));

            var cancelToken = new CancellationTokenSource();
            using (var transpiler = new XmiTranspiler(xmiPath, options))
            {
                Consoul.Write("Press any key to cancel...");

                var task = transpiler.TranspileAsync(cancelToken.Token);

                while (!task.IsCompleted)
                {
                    if (System.Console.KeyAvailable)
                    {
                        cancelToken.Cancel();
                    }
                }
                if (task.IsFaulted)
                {
                    Consoul.Write(task.Exception.ToString(), ConsoleColor.Red);
                    if (task.Exception.InnerExceptions.Any())
                    {
                        foreach (var innerException in task.Exception.InnerExceptions)
                        {
                            Consoul.Write(innerException.ToString(), ConsoleColor.Red);
                        }
                    }
                }
            }
            Consoul.Wait();
        }
    }
}
