using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='Asset Information Model' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectAssetInformationModel : PackagedElement
    {
        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Asset']")]
        public UmlClass? Asset { get; set; }

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Assets']

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Cutting Tool']")]
        public UmlPackage? CuttingTool { get; set; }

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Description']

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Files']")]
        public UmlPackage? Files { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Raw Material']")]
        public UmlPackage? RawMaterial { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='QIF']")]
        public UmlPackage? QIF { get; set; }

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Configuration']
    }
}