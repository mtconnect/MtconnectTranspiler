using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_RULE, Namespace = "")]
    public class OwnedRule : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
        public Specification? Specification { get; set; }
    }
}