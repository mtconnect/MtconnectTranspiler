using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedAttribute"/> where <c>xmi:type='uml:Property'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_ATTRIBUTE, Namespace = "")]
    public class UmlProperty : OwnedAttribute
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Property;

        /// <summary>
        /// <c>association</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.association, Namespace = "")]
        private string? _association { get; set; }
        /// <inheritdoc cref="_association"/>
        public string Association => _association ?? string.Empty;

        // TODO: Lookup the uml:Association[@name] to determine the expected Property Name
        // TODO: Figure out how to determine if the associated type is an array. Possibly just a reference to the lowerValue/upperValue elements

        /// <summary>
        /// <c>aggregation</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        private string? _aggregation { get; set; }
        /// <inheritdoc cref="_aggregation"/>
        public string Aggregation => _aggregation ?? string.Empty;

        /// <summary>
        /// <c>type</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        private string? _propertyType { get; set; }
        /// <inheritdoc cref="_propertyType"/>
        public string PropertyType => _propertyType ?? string.Empty;

        /// <summary>
        /// <c>isStatic</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isStatic, Namespace = "")]
        private bool _isStatic { get; set; }
        /// <inheritdoc cref="_isStatic"/>
        public bool IsStatic => _isStatic;

        /// <summary>
        /// <c>isReadOnly</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isReadOnly, Namespace = "")]
        private bool _isReadOnly { get; set; }
        /// <inheritdoc cref="_isReadOnly"/>
        public bool IsReadOnly => _isReadOnly;

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.LowerValue"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
        public LowerValue? LowerValue { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlInstanceValue"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
        public UmlInstanceValue? DefaultValue { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.XmiExtension"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension? Extension { get; set; }

        /// <summary>
        /// <c>visibility</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        private string _visibility { get; set; } = "public";
        /// <inheritdoc cref="_visibility"/>
        public string Visibility => _visibility;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }
    }
}