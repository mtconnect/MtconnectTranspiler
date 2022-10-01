using System;

namespace MtconnectTranspiler.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    internal class XPathAttribute : Attribute
    {
        /// <summary>
        /// The XPath expression
        /// </summary>
        public string Path { get; set; }

        public XPathAttribute(string path)
        {
            Path = path;
        }
    }
}
