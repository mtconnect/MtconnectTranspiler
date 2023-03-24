using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
    [XmlInclude(typeof(UmlOpaqueExpression))]
    public class Specification : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.BODY, Namespace = "")]
        public string? Body { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.LANGUAGE, Namespace = "")]
        public string? Language { get; set; }
    }
}