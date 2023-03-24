using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;xmi:exporter /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXPORTER, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExporter
    {
        /// <summary>
        /// <c>value</c> of the element
        /// </summary>
        [XmlText]
        public string? Value { get; set; }
    }
}