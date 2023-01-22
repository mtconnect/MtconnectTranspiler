using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='Observation Information Model' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class MTConnectObservationInformationModel : PackagedElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Conditions']

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Entry']

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Events']

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Samples']

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='Observations']

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Representations']")]
        public UmlPackage? Representations { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Package'][@name='Observation Types']")]
        public UmlPackage? ObservationTypes { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='DeviceStream']")]
        public UmlClass? DeviceStream { get; set; }

        // TODO: Add ./packagedElement[@xmi:type='uml:Association'][@name='ComponentStream']

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='ComponentStream']")]
        public UmlClass? ComponentStream { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Observation']")]
        public UmlClass? Observation { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Sample']")]
        public UmlClass? Sample { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Event']")]
        public UmlClass? Event { get; set; }

        [XPath("./packagedElement[@xmi:type='uml:Class'][@name='Condition']")]
        public UmlClass? Condition { get; set; }
    }
}