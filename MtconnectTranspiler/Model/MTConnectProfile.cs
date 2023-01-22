using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Profile' name='Profile' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectProfile : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='DataTypes']")]
        public ProfileDataTypes? ProfileDataTypes { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Stereotypes']")]
        public ProfileStereotypes? Stereotypes { get; set; }
    }
}