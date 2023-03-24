using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;upperValue /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.UPPER_VALUE, Namespace = "")]
    public class UpperValue : XmiElement
    {
        /// <summary>
        /// <c>value</c> attribute
        /// </summary>
        [XmlAttribute(XmlHelper.XmiStructure.value, Namespace = "")]
        public string? Value { get; set; }
    }
}