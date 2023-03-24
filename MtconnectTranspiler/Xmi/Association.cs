using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;assocation /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.ASSOCIATION, Namespace = "")]
    public class Association
    {
        /// <summary>
        /// <c>href</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.href, Namespace = "")]
        public string? Href { get; set; }
    }
}