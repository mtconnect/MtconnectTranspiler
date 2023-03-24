using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;type /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.TYPE, Namespace = "")]
    public class Type : XmiElement
    {
        /// <summary>
        /// <c>href</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.href, Namespace = "")]
        public string? Href { get; set; }
    }
}