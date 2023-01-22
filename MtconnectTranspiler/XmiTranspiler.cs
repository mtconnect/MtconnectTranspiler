using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler
{
    public class XmiTranspiler : IDisposable
    {
        private readonly ILogger<XmiTranspiler> _logger;

        /// <summary>
        /// Options for where to publish the transpiled source code.
        /// </summary>
        public readonly TranspilerOptions Options;

        private Stack<string> CompletedFiles { get; set; } = new Stack<string>();

        public XmiTranspiler(TranspilerOptions options, ILogger<XmiTranspiler> logger = null)
        {
            _logger = logger;
            Options = options;
        }

        public async Task TranspileAsync(string xmiPath, CancellationToken cancellationToken = default)
        {
            if (!File.Exists(xmiPath)) throw new FileNotFoundException("Could not find specified XMI file", xmiPath);

            // NOTE: It's important for this method to handle transpile multiple languages at once isntead of iterating through the XMI multiple times for each language.
            // NOTE: Make sure multiple project options cane be supplied to this class to handle concurrently processing multiple languages as we process the XMI.

            var deserializer = XmiDeserializer.FromFile(xmiPath);
            await TranspileAsync(deserializer, cancellationToken);
        }

        public async Task TranspileAsync(Uri git, CancellationToken cancellationToken = default)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(git, cancellationToken);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();

                    var deserializer = XmiDeserializer.FromXml(xml);
                    await TranspileAsync(deserializer, cancellationToken);
                }
            }
        }

        private async Task TranspileAsync(XmiDeserializer deserializer, CancellationToken cancellationToken = default)
        {
            MTConnectModel? model = deserializer.Deserialize<MTConnectModel>("//uml:Model[@name='MTConnect']", cancellationToken);
            if (model == null)
            {
                var serializationException = new SerializationException("Failed to deserialize XMI into MTConnectModel");
                _logger?.LogError(serializationException, serializationException.Message);
                throw serializationException;
            }
            _logger?.LogDebug("Successfully deserialized XMI into MTConnectModel");
            await TranspileAsync(model, cancellationToken);
        }

        /// <summary>
        /// Begins a task for transpiling the XMI document (see <see cref="XmiFilePath"/>) into the expected language.
        /// </summary>
        /// <param name="cancellationToken">Reference to a cancellation token to quit the asynchronous task.</param>
        /// <returns>The running task of transpiling.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        private async Task TranspileAsync(MTConnectModel model, CancellationToken cancellationToken = default)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            // NOTE: It's important for this method to handle transpile multiple languages at once isntead of iterating through the XMI multiple times for each language.
            // NOTE: Make sure multiple project options cane be supplied to this class to handle concurrently processing multiple languages as we process the XMI.
            ITranspilerSink[] transpilers = Options.Transpilers.ToArray();

            List<Task> tasks = new List<Task>();

            foreach (var transpiler in transpilers)
            {
                if (cancellationToken.IsCancellationRequested) break;

                var task = transpiler.Transpile(model);
                if (task != null)
                    tasks.Add(task.ContinueWith(t => { CompletedFiles.Push(t.Result); }, cancellationToken));
            }

            if (tasks.Any())
            {
                await Task.WhenAll(tasks);
            }
        }

        public void Dispose() { }
    }
}
