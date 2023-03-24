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
        public override string Type => XmlHelper.UmlStructure.Property;

        /// <summary>
        /// Represents the <c>association</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.association, Namespace = "")]
        private string _association { get; set; }
        /// <inheritdoc cref="_association"/>
        public string Association => _association;
        // TODO: Lookup the uml:Association[@name] to determine the expected Property Name
        // TODO: Figure out how to determine if the associated type is an array. Possibly just a reference to the lowerValue/upperValue elements

        /// <summary>
        /// Represents the <c>aggregation</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        private string _aggregation { get; set; }
        /// <inheritdoc cref="_aggregation"/>
        public string Aggregation => _aggregation;

        /// <summary>
        /// Represents the <c>type</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        private string _propertyType { get; set; }
        /// <inheritdoc cref="_propertyType"/>
        public string PropertyType => _propertyType;

        /// <summary>
        /// Represents the <c>isStatic</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isStatic, Namespace = "")]
        private bool _isStatic { get; set; }
        /// <inheritdoc cref="_isStatic"/>
        public bool IsStatic => _isStatic;

        /// <summary>
        /// Represents the <c>isReadOnly</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isReadOnly, Namespace = "")]
        private bool _isReadOnly { get; set; }
        /// <inheritdoc cref="_isReadOnly"/>
        public bool IsReadOnly => _isReadOnly;

        [XmlElement(ElementName = XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
        public LowerValue? LowerValue { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
        public UmlInstanceValue? DefaultValue { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension? Extension { get; set; }

        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }
    }
}