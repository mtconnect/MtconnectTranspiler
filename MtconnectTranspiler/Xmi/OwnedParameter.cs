using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_PARAMETER, Namespace = "")]
    public class OwnedParameter : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment? Comment { get; set; }

        // TODO: Get <defaultValue />
    }
}