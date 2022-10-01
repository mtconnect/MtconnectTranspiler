using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the model profile for MTConnect
    /// </summary>
    public class Profile : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        // TODO: Add XPATH attribute to get ./*[@name='DataTypes']
        [XPath("./*[@name='DataTypes']")]
        public ProfileDataTypes? ProfileDataTypes { get; set; }
    }
}