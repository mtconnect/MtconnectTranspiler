using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='MTConnectDevices Response Document' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectDevices : ResponseDocument
    {
        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='MTConnectDevices']")]
        public UmlClass? Root { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Header']")]
        public UmlClass? Header { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Header']")]
        public UmlClass? AssetCount { get; set; }
    }
}