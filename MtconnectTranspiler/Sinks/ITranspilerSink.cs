using MtconnectTranspiler.Xmi;
using System.Threading;

namespace MtconnectTranspiler.Sinks
{
    /// <summary>
    /// Basic interface for transpiling the XMI model into another language.
    /// </summary>
    public interface ITranspilerSink
    {
        /// <summary>
        /// Transpiles the XMI definition of the MTConnect Standard into some other format.
        /// </summary>
        /// <param name="model">Object-oriented copy of the XMI structure in the context of the MTConnect Standard.</param>
        /// <param name="cancellationToken">Reference to a cancellation token, the Transpile method may be a long running operation.</param>
        void Transpile(XmiDocument model, CancellationToken cancellationToken = default);
    }
}
