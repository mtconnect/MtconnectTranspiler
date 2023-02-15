using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtconnectTranspiler.Sinks.CSharp.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class ScribanTemplateAttribute : Attribute
    {
        public string Filename { get; }

        public ScribanTemplateAttribute(string filename)
        {
            Filename = filename;
        }
    }
}
