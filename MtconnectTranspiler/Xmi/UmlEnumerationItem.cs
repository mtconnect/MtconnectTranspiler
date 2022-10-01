using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents an individual Enumeration value.
    /// </summary>
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL, Namespace = "")]
    public class UmlEnumerationItem : OwnedLiteral
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment? Comment { get; set; }
    }
}