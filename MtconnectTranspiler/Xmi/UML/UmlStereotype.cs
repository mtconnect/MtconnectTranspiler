using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Stereotype' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlStereotype : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        [XPath("./*[@xmi:type='uml:Property']")]
        public UmlProperty[]? Properties { get; set; }
    }
}