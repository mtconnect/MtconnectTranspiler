using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DOCUMENTATION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiDocumentation
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXPORTER, Namespace = XmlHelper.XmiNamespace)]
        public XmiExporter? Exporter { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.EXPORTER_VERSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExporterVersion? ExporterVersion { get; set; }
    }
}