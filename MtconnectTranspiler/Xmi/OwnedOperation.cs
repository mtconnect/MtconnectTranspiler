using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;ownedOperation /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_OPERATION, Namespace = "")]
    public class OwnedOperation : XmiElement
    {
        /// <summary>
        /// <c>visibility</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <c>isQuery</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isQuery, Namespace = "")]
        public bool isQuery { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comment { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedParameter"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_PARAMETER)]
        public OwnedParameter[]? Parameters { get; set; }
    }
}