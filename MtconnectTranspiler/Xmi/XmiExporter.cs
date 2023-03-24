using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXPORTER, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExporter
    {
        [XmlText]
        public string Value { get; set; }
    }
}