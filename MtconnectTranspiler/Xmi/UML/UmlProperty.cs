using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Linq;
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
        public string? Association { get; set; }

        // TODO: Lookup the uml:Association[@name] to determine the expected Property Name
        // TODO: Figure out how to determine if the associated type is an array. Possibly just a reference to the lowerValue/upperValue elements

        /// <summary>
        /// <c>aggregation</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        public string? Aggregation { get; set; }

        /// <summary>
        /// <c>type</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        public string? PropertyType { get; set; }

        /// <summary>
        /// <c>isStatic</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isStatic, Namespace = "")]
        public bool IsStatic { get; set; }

        /// <summary>
        /// <c>isReadOnly</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isReadOnly, Namespace = "")]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.LowerValue"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
        public LowerValue? LowerValue { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
        public XmlElement? DefaultValueElement { get; set; }
        private DefaultValue? _defaultValue;
        public DefaultValue? DefaultValue
        {
            get
            {
                if (_defaultValue != null)
                    return _defaultValue;
                if (DefaultValueElement == null)
                    return null;

                XmlRootAttribute xRoot = new XmlRootAttribute
                {
                    ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE,
                    IsNullable = true,
                    Namespace = ""
                };

                //XmlSerializer serial = new XmlSerializer(typeof(T), xRoot);
                using var xReader = new XmlNodeReader(DefaultValueElement);

                XmlSerializer? serial = null;
                string umlType = DefaultValueElement.GetAttribute(XmlHelper.XmiStructure.type, XmlHelper.XmiNamespace);
                switch (umlType)
                {
                    case XmlHelper.UmlStructure.InstanceValue:
                        serial = new XmlSerializer(typeof(UmlInstanceValue), xRoot);
                        break;
                    case XmlHelper.UmlStructure.LiteralString:
                        serial = new XmlSerializer(typeof(UmlLiteralString), xRoot);
                        break;
                    default:
                        break;
                }

                if (serial != null)
                {
                    object? deserializedObject = serial.Deserialize(xReader);

                    if (deserializedObject != null)
                    {
                        switch (umlType)
                        {
                            case XmlHelper.UmlStructure.InstanceValue:
                                _defaultValue = deserializedObject as UmlInstanceValue;
                                break;
                            case XmlHelper.UmlStructure.LiteralString:
                                _defaultValue = deserializedObject as UmlLiteralString;
                                break;
                            default:
                                break;
                        }
                    }
                }

                return _defaultValue;
            }
        }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.XmiExtension"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension? Extension { get; set; }

        /// <summary>
        /// <c>visibility</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        public string Visibility { get; set; } = "public";

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }
    }
}