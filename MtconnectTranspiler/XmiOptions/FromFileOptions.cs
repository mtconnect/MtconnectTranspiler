using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using System.IO;

namespace MtconnectTranspiler.XmiOptions
{
    /// <summary>
    /// Options for constructing an instance of <see cref="TranspilerDispatcher"/> by retrieving the <see cref="XmiDeserializer"/> using the <see cref="Filepath"/> as a reference to the <c>.xmi</c> of the MTConnect Standard SysML model.
    /// </summary>
    public class FromFileOptions : TranspilerDispatcherOptions
    {
        /// <summary>
        /// Reference to a copy of the <c>.xmi</c> file (in XML format) representing the MTConnect Standard SysML model.
        /// </summary>
        public string Filepath { get; set; } = string.Empty;

        /// <inheritdoc />
        /// <exception cref="FileNotFoundException"></exception>
        public override XmiDeserializer GetDeserializer(ILogger<XmiDeserializer> logger = null)
        {
            if (!File.Exists(Filepath))
                throw new FileNotFoundException("Could not find specified XMI file", Filepath);

            // NOTE: It's important for this method to handle transpile multiple languages at once isntead of iterating through the XMI multiple times for each language.
            // NOTE: Make sure multiple project options cane be supplied to this class to handle concurrently processing multiple languages as we process the XMI.

            var deserializer = XmiDeserializer.FromFile(Filepath, logger);
            return deserializer;
        }
    }
}
