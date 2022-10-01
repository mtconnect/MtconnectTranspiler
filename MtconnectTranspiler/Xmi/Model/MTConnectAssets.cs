using MtconnectTranspiler.Contracts.Attributes;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the model for the MTConnectAssets Response Document
    /// </summary>
    public class MTConnectAssets : ResponseDocument
    {
        // TODO: Add XPATH attribute to get ./*[@name='MTConnectAssets']
        [XPath("./*[@name='MTConnectAssets']")]
        public UmlClass Root { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='Header']
        [XPath("./*[@name='Header']")]
        public UmlClass Header { get; set; }
    }
}