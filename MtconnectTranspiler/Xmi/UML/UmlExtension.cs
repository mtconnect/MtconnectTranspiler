using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Extension' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlExtension : PackagedElement
    {
        public override string Type => "uml:Extension";

        [XmlElement(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
        public MemberEnd[]? MemberEnds { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_END, Namespace = "")]
        public UmlExtensionEnd? End { get; set; }

    }
}