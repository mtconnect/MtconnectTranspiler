using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MODEL, Namespace = XmlHelper.UmlNamespace)]
    public class UmlModel : XmiElement
    {
        public override string Type => XmlHelper.UmlStructure.Model;

        /// <summary>
        /// Collection of <c>&lt;ownedComment /&gt;</c> elements.
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of <c>&lt;packageImport /&gt;</c> elements.
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
        public UmlPackageImport[]? PackageImports { get; set; }

        /// <summary>
        /// Represents element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Profile' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public XmlElement[]? PackagedElements { get; set; }

        /// <summary>
        /// Internal switch property for <see cref="Profiles"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlProfile> _profiles;
        /// <summary>
        /// Collection of <c>&lt;packagedElement xmi:type='uml:Profile' /&gt;</c> elements.
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlProfile> Profiles => _profiles ??= PackagedElementCollection<UmlProfile>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Profile);

        /// <summary>
        /// Internal switch property for <see cref="Packages"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlPackage> _packages;
        /// <summary>
        /// Collection of <c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c> elements.
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlPackage> Packages => _packages ??= PackagedElementCollection<UmlPackage>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Package);
    }
}