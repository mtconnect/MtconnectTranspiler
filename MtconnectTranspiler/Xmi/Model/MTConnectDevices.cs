using MtconnectTranspiler.Contracts.Attributes;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the model for the MTConnectDevices Response Document
    /// </summary>
    public class MTConnectDevices : ResponseDocument
    {
        // TODO: Add XPATH attribute to get ./*[@name='MTConnectDevices']
        [XPath("./*[@name='MTConnectDevices']")]
        public UmlClass Root { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='Header']
        [XPath("./*[@name='Header']")]
        public UmlClass Header { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='AssetCount']
        [XPath("./*[@name='Header']")]
        public UmlClass AssetCount { get; set; }
    }
}