using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [XmlRoot(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
    public class Specification : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.BODY)]
        public string? Body { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.LANGUAGE)]
        public string? Language { get; set; }
    }
}