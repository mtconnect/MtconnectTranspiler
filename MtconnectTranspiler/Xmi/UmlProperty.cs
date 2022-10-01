using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_ATTRIBUTE, Namespace = "")]
    public class UmlProperty : OwnedAttribute
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        private string _aggregation { get; set; }
        public string Aggregation => _aggregation;

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        private string _type { get; set; }
        public string PropertyType => _type;
    }
}