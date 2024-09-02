using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;filePart /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.FILE_PART, Namespace = "")]
    public class FilePart
    {
        /// <summary>
        /// <c>name</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public string? Name { get; set; }

        /// <summary>
        /// <c>type</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        public string? Type { get; set; }

        /// <summary>
        /// <c>header</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.header, Namespace = "")]
        public string? Header { get; set; }

        /// <summary>
        /// Child element not handled in deserialization.
        /// </summary>
        [XmlAnyElement]
        public object[]? ChildElements { get; set; }

        /// <summary>
        /// Inner contents of the <c>&lt;filePart /&gt;</c> element.
        /// </summary>
        [XmlText]
        public string? Contents { get; set; }
    }
}