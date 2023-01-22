using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi.UML;
using System.Xml.Serialization;
using System;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='MTConnectAssets Response Document' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectAssets : ResponseDocument
    {
        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='MTConnectAssets']")]
        public UmlClass? Root { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Header']")]
        public UmlClass? Header { get; set; }
    }
}