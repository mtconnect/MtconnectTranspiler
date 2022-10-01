using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    /// <summary>
    /// Represents the data types and enumerations used throughout the standard
    /// </summary>
    public class ProfileDataTypes : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of enumeration used throughout the standard
        /// </summary>
        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:Enumeration']
        [XPath("./*[@xmi:type='uml:Enumeration']")]
        public UmlEnumeration[]? Enumerations { get; set; }

        /// <summary>
        /// Collection of extended data types used throughout the standard
        /// </summary>
        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:DataType']
        [XPath("./*[@xmi:type='uml:DataType']")]
        public DataType[]? DataTypes { get; set; }

        /// <summary>
        /// Collection of entity models used throughout the standard
        /// </summary>
        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:Class']
        [XPath("./*[@xmi:type='uml:Class']")]
        public UmlClass[]? Classes { get; set; }
    }
}