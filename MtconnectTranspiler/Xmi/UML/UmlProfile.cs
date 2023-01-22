using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Profile' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlProfile : PackagedElement
    {
        [XPath("./ownedComments[@xmi:type='uml:Comment']")]
        public UmlComment[]? Comments { get; set; }

        [XPath("./packageImport[@xmi:type='uml:PackageImport']")]
        public UmlPackageImport[]? Imports { get; set; }

        [XmlElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public PackagedElement[]? Elements { get; set; }

        [XPath("./metamodelReference/@xmi:idref")]
        public string MetaModelReference { get; set; }

        // TODO: Add appliedProfile
    }
}