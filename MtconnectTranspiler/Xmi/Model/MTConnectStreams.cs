using MtconnectTranspiler.Contracts.Attributes;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the model for the MTConnectStreams Response Document
    /// </summary>
    public class MTConnectStreams : ResponseDocument
    {
        // TODO: Add XPATH attribute to get ./*[@name='MTConnectStreams']
        [XPath("./*[@name='MTConnectStreams']")]
        public UmlClass Root { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='Header']
        [XPath("./*[@name='Header']")]
        public UmlClass Header { get; set; }
    }
}