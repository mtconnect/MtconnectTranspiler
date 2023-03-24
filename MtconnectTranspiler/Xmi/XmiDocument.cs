using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = "XMI", Namespace = XmlHelper.XmiNamespace)]
    public class XmiDocument
    {
        public XmiDocumentation? Documentation { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.MODEL, Namespace = XmlHelper.UmlNamespace)]
        public UmlModel? Model { get; set; }

        [XmlElement(ElementName = XmlHelper.ProfileStructure.NORMATIVE, Namespace = XmlHelper.ProfileNamespace)]
        public Normative[]? NormativeIntroductions { get; set; }

        [XmlElement(ElementName = XmlHelper.ProfileStructure.DEPRECATED, Namespace = XmlHelper.ProfileNamespace)]
        public Deprecated[]? Deprecations { get; set; }
    }
}