using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;xmi:Extension /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
    public class XmiExtension : XmiElement
    {
        /// <summary>
        /// <c>extender</c> attribute
        /// </summary>
        [XmlAttribute(XmlHelper.XmiStructure.extender, Namespace = "")]
        public string? Extender { get; set; }

        /// <summary>
        /// <c>filePart</c> elements
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.FILE_PART, Namespace = "")]
        public FilePart[]? FileParts { get; set; }

        [XmlAnyElement]
        public object[]? ChildElements { get; set; }
    }
}