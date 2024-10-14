using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;tag /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.TAG, Namespace = "")]
    public class Tag
    {
        /// <summary>
        /// <c>name</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public string? Name { get; set; }

        /// <summary>
        /// <c>tagID</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.tagId, Namespace = "")]
        public string? TagId { get; set; }

        /// <summary>
        /// <c>tagURI</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.tagUri, Namespace = "")]
        public string? TagUri { get; set; }
    }
}