using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;xmi:Documentation /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DOCUMENTATION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiDocumentation
    {
        /// <summary>
        /// Child <inheritdoc cref="XmiExporter"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXPORTER, Namespace = XmlHelper.XmiNamespace)]
        public XmiExporter? Exporter { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="XmiExporterVersion"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXPORTER_VERSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExporterVersion? ExporterVersion { get; set; }
    }
}