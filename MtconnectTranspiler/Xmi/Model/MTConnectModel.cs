using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the root model for the MTConnect structure
    /// </summary>
    [Serializable, XmlRoot(ElementName = "Model", Namespace = XmlHelper.UmlNamespace)]
    public class MTConnectModel : XmiElement
    {
        /// <summary>
        /// Description content for the MTConnect Model in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='Profile']
        [XPath("./*[@name='Profile']")]
        public Profile? Profile { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='MTConnect Protocol']
        [XPath("./*[@name='MTConnect Protocol']")]
        public MTConnectProtocol? MTConnectProtocol { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='Device Information Model']
        [XPath("./*[@name='Device Information Model']")]
        public DeviceModel? DeviceModel { get; set; }
    }
}