using System;

namespace MtconnectTranspiler.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    internal class XPathAttribute : Attribute
    {
        /// <summary>
        /// The XPath expression
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Overrides the target type from the inherited property type to this type.
        /// </summary>
        public Type? Type { get; set; }

        public XPathAttribute(string path, Type? type = null)
        {
            Path = path;
            Type = type;
        }
    }
}
