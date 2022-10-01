using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;ownedComment /&gt;</c>.
    /// </summary>
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    public class OwnedComment : XmiElement {
        /// <summary>
        /// Markdown contents of the comment.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.BODY, Namespace = "")]
        public string? Body { get; set; }
    }
}