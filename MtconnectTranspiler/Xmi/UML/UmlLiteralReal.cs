using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/> where <c>xmi:type='uml:LiteralReal'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
    public class UmlLiteralReal : DefaultValue
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.LiteralReal;

        /// <summary>
        /// <c>value</c> attribute
        /// </summary>
        [XmlIgnore]
        public float? Value { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.value, Namespace = "")]
        public string? ValueSerializable
        {
            get => Value?.ToString();
            set
            {
                if (!string.IsNullOrEmpty(value) && float.TryParse(value, out var result))
                    Value = result;
                else
                    Value = null;
            }
        }
    }
}