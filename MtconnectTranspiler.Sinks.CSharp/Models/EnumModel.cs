using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [Serializable]
    internal class EnumModel
    {
        public MtconnectTranspiler.Xmi.UmlEnumeration Enumeration { get; set; }

        public EnumModel() { }
    }
}
