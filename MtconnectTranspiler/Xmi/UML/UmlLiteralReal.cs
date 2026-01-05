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
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.value, Namespace = "")]
        public float? Value { get; set; }
    }
}