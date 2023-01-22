using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='Device Information Model' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectDeviceInformationModel : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package']")]
        public MTConnectDeviceInformationModel[]? SubModels { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class']")]
        public UmlClass[]? Classes { get; set; }
    }
}