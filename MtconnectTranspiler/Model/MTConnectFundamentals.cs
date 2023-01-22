using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='Fundamentals' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectFundamentals : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='MTConnect Protocol']")]
        public MTConnectProtocol? MTConnectProtocol { get; set; }
    }
}