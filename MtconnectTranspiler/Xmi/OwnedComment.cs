using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;ownedComment /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    [XmlInclude(typeof(UmlComment))]
    public class OwnedComment : XmiElement {
        /// <summary>
        /// <c>body</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.BODY, Namespace = "")]
        public string? Body { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment? SubComment { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.AnnotatedElement"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.ANNOTATED_ELEMENT, Namespace = "")]
        public AnnotatedElement? AnnotatedElement { get; set; }
    }
}