using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='MTConnect Protocol' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectProtocol : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='MTConnectAssets Response Document']")]
        public MTConnectAssets? MTConnectAssets { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='MTConnectDevices Response Document']")]
        public MTConnectDevices? MTConnectDevices { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='MTConnectStreams Response Document']")]
        public MTConnectStreams? MTConnectStreams { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='MTConnectErrors Response Document']")]
        public MTConnectErrors? MTConnectErrors { get; set; }

        // TODO: ./packagedElement[@xmi:type='uml:Package'][@name='REST Protocol']
    }
}