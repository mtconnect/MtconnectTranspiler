using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/> where <c>xmi:type='uml:LiteralInteger'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
    public class UmlLiteralInteger : DefaultValue
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.LiteralInteger;

        /// <summary>
        /// <c>value</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.value, Namespace = "")]
        public int? Value { get; set; }
    }
}