using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlClass : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of properties applied to an entity
        /// </summary>
        [XPath("./ownedAttribute[@xmi:type='uml:Property']")]
        public UmlProperty[]? Properties { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        public string _isAbstract { get; set; }
        public bool IsAbstract => _isAbstract?.Equals("true", System.StringComparison.OrdinalIgnoreCase) == true;

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_RULE)]
        public UmlConstraint[]? Constraints { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization? Generalization { get; set; }
    }
}