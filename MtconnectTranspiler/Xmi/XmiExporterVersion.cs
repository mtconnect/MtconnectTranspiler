using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;xmi:exporterVersion /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXPORTER_VERSION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExporterVersion
    {
        /// <summary>
        /// <c>value</c> of the element
        /// </summary>
        [XmlText]
        public string? Value { get; set; }
    }
}