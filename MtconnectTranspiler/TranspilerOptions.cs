
using MtconnectTranspiler.Contracts;
using System.Collections.Generic;

namespace MtconnectTranspiler
{
    public class TranspilerOptions
    {
        ///// <summary>
        ///// Transpiler to convert XMI into the appropriate source code.
        ///// </summary>
        public ICollection<ITranspilerSink> Transpilers { get; set; } = new List<ITranspilerSink>();

        public TranspilerOptions() { }
    }
}
