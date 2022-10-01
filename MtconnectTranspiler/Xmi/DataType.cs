using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents additional or overriden data types in Cameo
    /// </summary>
    [XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class DataType : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment? Comment { get; set; }
    }
}