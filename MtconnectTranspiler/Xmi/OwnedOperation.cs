using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_OPERATION, Namespace = "")]
    public class OwnedOperation : XmiElement
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        public string? Visibility { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isQuery, Namespace = "")]
        internal string? _isQuery { get; set; }
        public bool isQuery => bool.Parse(_isQuery);

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comment { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_PARAMETER)]
        public OwnedParameter[]? Parameters { get; set; }
    }
}