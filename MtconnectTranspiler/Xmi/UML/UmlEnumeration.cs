using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:Enumeration' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlEnumeration : PackagedElement
    {
        /// <summary>
        /// Collection of enumeration values
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL)]
        public UmlEnumerationLiteral[]? Items { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION)]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}