using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Profile' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlProfile : PackagedElement
    {
        public override string Type => XmlHelper.UmlStructure.Profile;

        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        [XmlElement(ElementName = XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
        public UmlPackageImport[]? Imports { get; set; }

        /// <summary>
        /// Represents element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public XmlElement[]? PackagedElements { get; set; }

        [XmlIgnore]
        private PackagedElementCollection<UmlPackage> _packages;
        [XmlIgnore]
        public PackagedElementCollection<UmlPackage> Packages => _packages ??= PackagedElementCollection<UmlPackage>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Package);

        [XmlElement(ElementName = XmlHelper.XmiStructure.METAMODEL_REFERENCE, Namespace = "")]
        public MetamodelReference? MetaModelReference { get; set; }

        // TODO: Add appliedProfile
    }
}