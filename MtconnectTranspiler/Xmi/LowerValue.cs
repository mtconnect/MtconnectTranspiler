using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;lowerValue /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
    public class LowerValue : XmiElement
    {
        /// <summary>
        /// <c>value</c> attribute
        /// </summary>
        [XmlAttribute(XmlHelper.XmiStructure.value, Namespace = "")]
        public string? Value { get; set; }
    }
}