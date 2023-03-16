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
        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Represents the <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element(s).
        /// </summary>
        [XPath("./ownedAttribute[@xmi:type='uml:Property']")]
        public UmlProperty[]? Properties { get; set; }

        /// <summary>
        /// Represents the <c>isAbstract</c> attribute in a <c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        public string _isAbstract { get; set; }
        /// <inheritdoc cref="_isAbstract"/>
        public bool IsAbstract => _isAbstract?.Equals("true", System.StringComparison.OrdinalIgnoreCase) == true;

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_RULE)]
        public UmlConstraint[]? Constraints { get; set; }

        /// <summary>
        /// Represents the <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c> element.
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization? Generalization { get; set; }
    }
}