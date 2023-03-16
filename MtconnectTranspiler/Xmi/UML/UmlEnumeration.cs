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
        /// Represents the <c>&lt;ownedLiteral xmi:type='uml:EnumerationLiteral' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL)]
        public UmlEnumerationLiteral[]? Items { get; set; }

        /// <summary>
        /// Represents the <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION)]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}