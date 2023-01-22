using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Basic interface for transpiling the XMI model into another language.
    /// </summary>
    public interface ITranspilerSink
    {
        /// <summary>
        /// Transpiles the XMI definition of an Enumeration into another language.
        /// </summary>
        /// <param name="model">Reference to the deserialized XMI model.</param>
        /// <returns>The transpiled source code filepath.</returns>
        /// <exception cref="NotImplementedException"></exception>
        Task<string> Transpile(MTConnectModel model);
    }
}
