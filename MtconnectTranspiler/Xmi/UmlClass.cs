using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents an entity in the model
    /// </summary>
    [XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlClass : PackagedElement
    {
        /// <summary>
        /// Collection of properties applied to an entity
        /// </summary>
        // TODO: Add XPATH attribute to get ./*[@xmi:type='uml:Property']
        [XPath("./*[@xmi:type='uml:Property']")]
        public UmlProperty[]? Properties { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        private string _isAbstract { get; set; }
        public bool IsAbstract => _isAbstract?.Equals("true", System.StringComparison.OrdinalIgnoreCase) == true;

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_RULE)]
        public OwnedRule[]? Rules { get; set; }
    }
}