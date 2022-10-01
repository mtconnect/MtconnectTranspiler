using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the model for the Response Documents
    /// </summary>
    public class MTConnectProtocol : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='MTConnectAssets Response Document']
        [XPath("./*[@name='MTConnectAssets Response Document']")]
        public MTConnectAssets? MTConnectAssets { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='MTConnectDevices Response Document']
        [XPath("./*[@name='MTConnectDevices Response Document']")]
        public MTConnectDevices? MTConnectDevices { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='MTConnectStreams Response Document']
        [XPath("./*[@name='MTConnectStreams Response Document']")]
        public MTConnectStreams? MTConnectStreams { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='MTConnectErrors Response Document']
        [XPath("./*[@name='MTConnectErrors Response Document']")]
        public MTConnectErrors? MTConnectErrors { get; set; }
    }
}