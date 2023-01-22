using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='MTConnectErrors Response Document' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectErrors : ResponseDocument
    {
        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='MTConnectError']")]
        public UmlClass? Root { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Header']")]
        public UmlClass? Header { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Error']")]
        public UmlClass? Error { get; set; }
    }
}