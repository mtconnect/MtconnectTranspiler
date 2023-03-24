using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXPORTER_VERSION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExporterVersion
    {
        [XmlText]
        public string Value { get; set; }
    }
}