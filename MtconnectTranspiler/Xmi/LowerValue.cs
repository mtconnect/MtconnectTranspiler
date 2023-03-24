using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents a <c>&lt;lowerValue /&gt;</c> element.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
    public class LowerValue : XmiElement
    {
        /// <summary>
        /// Represents the <c>value</c> attribute in a <c>&lt;lowerValue /&gt;</c> element.
        /// </summary>
        [XmlAttribute(XmlHelper.XmiStructure.value, Namespace = "")]
        public string Value { get; set; }
    }
}