using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;ownedComment /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    [XmlInclude(typeof(UmlComment))]
    public class OwnedComment : XmiElement {
        /// <summary>
        /// Markdown contents of the comment.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.BODY, Namespace = "")]
        public string? Body { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment? SubComment { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.ANNOTATED_ELEMENT, Namespace = "")]
        public AnnotatedElement? AnnotatedElement { get; set; }
    }
}