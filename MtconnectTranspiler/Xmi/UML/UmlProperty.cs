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
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UpperValue"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.UPPER_VALUE, Namespace = "")]
        public UpperValue? UpperValue { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
        public XmlElement? DefaultValueElement { get; set; }

        private DefaultValue? _defaultValue;
        /// <summary>
        /// Reference to the literal value for <see cref="DefaultValueElement"/>. For example, consider:<br/>
        /// <example>
        /// <pre><code>
        /// &lt;defaultValue xmi:type='uml:InstanceValue' xmi:id='{SysML ID}' instance='_19_0_3_68e0225_1640604494524_915253_429' /&gt;<br/>
        /// ...
		///	&lt;packagedElement xmi:type='uml:Enumeration' xmi:id='{SysML ID}' name='MaintenanceListIntervalEnum'&gt;<br/>
		///		&lt;ownedLiteral xmi:type='uml:EnumerationLiteral' xmi:id='_19_0_3_68e0225_1640604494524_915253_429' name='ABSOLUTE'/&gt;<br/>
		///		&lt;ownedLiteral xmi:type='uml:EnumerationLiteral' xmi:id='{SysML ID}' name='INCREMENTAL'/&gt;<br/>
		///	&lt;/packagedElement&gt;
        /// </code></pre>
        /// </example><br/>
        /// In this case, <see cref="DefaultValue"/> would be equal to the element for <c>ABSOLUTE</c>.
        /// </summary>
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
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.XmiExtension"/> and may contain lower and upper value limits. For example, multiplicitiy of <c>1</c> may look like this:<br/>
        /// <example>
        /// <pre><code>
        /// &lt;xmi:Extension&gt;
        ///     &lt;modelExtension&gt;
        ///         &lt;lowerValue xmi:type='uml:LiteralInteger' xmi:id='...' value='1'/&gt;
        ///     &lt;/modelExtension&gt;
        /// &lt;/xmi:Extension&gt;
        /// &lt;xmi:Extension&gt;
        ///     &lt;modelExtension&gt;
        ///         &lt;upperValue xmi:type='uml:LiteralInteger' xmi:id='...' value='1'/&gt;
        ///     &lt;/modelExtension&gt;
        /// &lt;/xmi:Extension&gt;
        /// </code></pre>
        /// </example>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension[]? Extensions { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }
    }
}