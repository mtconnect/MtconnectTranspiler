using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents a <c>&lt;xmi:Extension /&gt;</c> element.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExtension : XmiElement
    {
        /// <summary>
        /// Represents the <c>extender</c> attribute in a <c>&lt;xmi:Extension /&gt;</c> element.
        /// </summary>
        [XmlAttribute(XmlHelper.XmiStructure.extender, Namespace = "")]
        public string Extender { get; set; }
    }
}