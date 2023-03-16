using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlDataType : PackagedElement
    {
        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Represents the <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION)]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}