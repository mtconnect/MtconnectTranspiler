using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_PARAMETER, Namespace = "")]
    public class OwnedParameter : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment? Comment { get; set; }

        // TODO: Get <defaultValue />
    }
}