using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents an Enumeration of values.
    /// </summary>
    [XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlEnumeration : PackagedElement
    {
        /// <summary>
        /// Collection of enumeration values
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL)]
        public UmlEnumerationItem[]? Items { get; set; }
    }
}