using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace MtconnectTranspiler
{
    /// <summary>
    /// A service responsible for retrieving a copy of the <c>.xmi</c> representing the MTConnect Standard SysML model and dispatching the deserialized model to implementations of <see cref="ITranspilerSink"/>.
    /// </summary>
    public class TranspilerDispatcher : IDisposable
    {
        private List<ITranspilerSink> _sinks = new List<ITranspilerSink>();

        private readonly ILogger<TranspilerDispatcher>? _logger = null;

        /// <summary>
        /// Reference to the options used to retrieve the <c>.xmi</c> representing the MTConnect Standard SysML model.
        /// </summary>
        public TranspilerDispatcherOptions Options { get; private set; }

        public TranspilerDispatcher(TranspilerDispatcherOptions options, ILogger<TranspilerDispatcher>? logger = null)
        {
            _logger = logger;
            Options = options;
        }

        /// <summary>
        /// Adds an implementation of the <see cref="ITranspilerSink"/> interface to the collection of sinks to dispatch to.
        /// </summary>
        /// <param name="sink">Implementation of <see cref="ITranspilerSink"/></param>
        public void AddSink(ITranspilerSink sink) => _sinks.Add(sink);

        /// <summary>
        /// Transpiles the MTConnect Standard SysML model (according to <see cref="TranspilerDispatcherOptions"/>) and then internally calls <see cref="DispatchAsync"/> to begin dispatching.
        /// </summary>
        /// <param name="cancellationToken">Optional reference to a cancellation token since this operation may be a long running method.</param>
        /// <returns>Task</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task TranspileAsync(CancellationToken cancellationToken = default)
        {
            XmiDeserializer deserializer = Options.GetDeserializer();
            if (deserializer == null) throw new ArgumentNullException(nameof(deserializer), "XmiDeserializer cannot be null and must have loaded improperly");

            MTConnectModel? model = deserializer.Deserialize<MTConnectModel>("//uml:Model[@name='MTConnect']", cancellationToken);
            if (model == null)
            {
                var serializationException = new SerializationException("Failed to deserialize XMI into MTConnectModel");
                _logger?.LogError(serializationException, serializationException.Message);
                throw serializationException;
            }
            _logger?.LogDebug("Successfully deserialized XMI into MTConnectModel");


            await DispatchAsync(model, cancellationToken);
        }

        /// <summary>
        /// Dispatches the provided <see cref="MTConnectModel"/> to all implementations of <see cref="ITranspilerSink"/> that have been added to this <see cref="TranspilerDispatcher"/>.
        /// </summary>
        /// <param name="model">Reference to the <see cref="MTConnectModel"/> that was deserialized from a copy of the MTConnect Standard SysML model.</param>
        /// <param name="cancellationToken">Optional reference to a cancellation token since this operation may be a long running method.</param>
        /// <returns>Task</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task DispatchAsync(MTConnectModel model, CancellationToken cancellationToken = default)
        {

            if (model == null) throw new ArgumentNullException(nameof(model));

            // NOTE: It's important for this method to handle transpile multiple languages at once isntead of iterating through the XMI multiple times for each language.
            // NOTE: Make sure multiple project options cane be supplied to this class to handle concurrently processing multiple languages as we process the XMI.
            List<Task> tasks = new List<Task>();

            foreach (var sink in _sinks)
            {
                if (cancellationToken.IsCancellationRequested) break;

                var task = Task.Run(() => sink.Transpile(model, cancellationToken), cancellationToken);
                if (task != null) tasks.Add(task);
            }

            if (tasks.Any()) await Task.WhenAll(tasks);
        }

        public void Dispose() {
            _sinks.Clear();
        }
    }
}
