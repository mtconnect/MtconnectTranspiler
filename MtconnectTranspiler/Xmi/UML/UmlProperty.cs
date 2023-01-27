using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_ATTRIBUTE, Namespace = "")]
    public class UmlProperty : OwnedAttribute
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.association, Namespace = "")]
        public string _association { get; set; }
        public string Association => _association;
        // TODO: Lookup the uml:Association[@name] to determine the expected Property Name
        // TODO: Figure out how to determine if the associated type is an array. Possibly just a reference to the lowerValue/upperValue elements

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        public string _aggregation { get; set; }
        public string Aggregation => _aggregation;

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        public string _visibility { get; set; } = "public";
        public string Visibility => _visibility;

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        public string _type { get; set; }
        /// <summary>
        /// Reference to the primitive type or the xmi:id of the complex type
        /// </summary>
        public string PropertyType => _type;

        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }
    }
}