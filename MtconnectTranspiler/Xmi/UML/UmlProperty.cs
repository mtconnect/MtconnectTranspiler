using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_ATTRIBUTE, Namespace = "")]
    public class UmlProperty : OwnedAttribute
    {
        /// <summary>
        /// Represents the <c>association</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.association, Namespace = "")]
        internal string _association { get; set; }
        /// <inheritdoc cref="_association"/>
        public string Association => _association;
        // TODO: Lookup the uml:Association[@name] to determine the expected Property Name
        // TODO: Figure out how to determine if the associated type is an array. Possibly just a reference to the lowerValue/upperValue elements

        /// <summary>
        /// Represents the <c>aggregation</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        internal string _aggregation { get; set; }
        /// <inheritdoc cref="_aggregation"/>
        public string Aggregation => _aggregation;

        /// <summary>
        /// Represents the <c>visibility</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        internal string _visibility { get; set; } = "public";
        /// <inheritdoc cref="_visibility"/>
        public string Visibility => _visibility;

        /// <summary>
        /// Represents the <c>type</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        internal string _propertyType { get; set; }
        /// <inheritdoc cref="_propertyType"/>
        public string PropertyType => _propertyType;

        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }
    }
}