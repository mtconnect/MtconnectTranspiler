using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/> where <c>xmi:type='uml:LiteralBoolean'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
    public class UmlLiteralBoolean : DefaultValue
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.LiteralBoolean;

        /// <summary>
        /// <c>value</c> attribute
        /// </summary>
        [XmlIgnore]
        public bool? Value { get; set; }

        // Serializer uses this; returns null if Value is null, which omits the attribute
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.value, Namespace = "")]
        public string ValueSerializable
        {
            get => Value?.ToString().ToLower(); // UML expects lowercase "true"/"false"
            set {
                if (!string.IsNullOrEmpty(value) && bool.TryParse(value, out bool result))
                    Value = result;
                else
                    Value = null;
            }
        }
    }
}