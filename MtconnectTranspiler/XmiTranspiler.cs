using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler
{
    public class XmiTranspiler : IDisposable
    {
        /// <summary>
        /// Reference to the filepath for the source XMI.
        /// </summary>
        public readonly string XmiFilePath;

        /// <summary>
        /// Options for where to publish the transpiled source code.
        /// </summary>
        public readonly TranspilerOptions Options;

        private Stack<string> CompletedFiles { get; set; } = new Stack<string>();

        public XmiTranspiler(string xmiPath, TranspilerOptions options)
        {
            XmiFilePath = xmiPath;
            Options = options;
        }

        /// <summary>
        /// Begins a task for transpiling the XMI document (see <see cref="XmiFilePath"/>) into the expected language.
        /// </summary>
        /// <param name="cancellationToken">Reference to a cancellation token to quit the asynchronous task.</param>
        /// <returns>The running task of transpiling.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public async Task TranspileAsync(CancellationToken cancellationToken)
        {
            if (!File.Exists(XmiFilePath)) throw new FileNotFoundException("Could not find specified XMI file", XmiFilePath);

            // NOTE: It's important for this method to handle transpile multiple languages at once isntead of iterating through the XMI multiple times for each language.
            // NOTE: Make sure multiple project options cane be supplied to this class to handle concurrently processing multiple languages as we process the XMI.
            ITranspilerSink[] transpilers = Options.Transpilers.ToArray();

            List<Task> tasks = new List<Task>();

            var deserializer = new XmiDeserializer(XmiFilePath);
            MTConnectModel? model = null;
            try
            {
                model = deserializer.Deserialize<MTConnectModel>("//uml:Model[@name='MTConnect']", cancellationToken);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }

            if (model != null)
            {
                foreach (var transpiler in transpilers)
                {
                    if (cancellationToken.IsCancellationRequested) break;

                    var task = transpiler.Transpile(model);
                    if (task != null) tasks.Add(task);
                }
            }

            if (tasks.Any())
            {
                await Task.WhenAll(tasks);
            }
        }

        public void Dispose() { }
    }
}
