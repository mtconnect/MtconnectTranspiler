using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
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
        [XPath("./memberEnd/@xmi:idref")]
        public string[]? MemberEnds { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_END)]
        public UmlExtensionEnd? End { get; set; }

    }
}