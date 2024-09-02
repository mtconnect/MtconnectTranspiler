using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <c>uml:Model</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MODEL, Namespace = XmlHelper.UmlNamespace)]
    public class UmlModel : XmiElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Model;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlPackageImport"/>
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
        public UmlPackageImport[]? PackageImports { get; set; }

        private XmlElement[]? _packagedElements;
        /// <summary>
        /// Represents <c>&lt;packagedElement /&gt;</c> element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Profile' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public XmlElement[]? PackagedElements
        {
            get { return _packagedElements; }
            set
            {
                _packagedElements = value;
                _profiles = PackagedElementCollection<UmlProfile>.Deserialize(_packagedElements, XmlHelper.UmlStructure.Profile);
                _packages = PackagedElementCollection<UmlPackage>.Deserialize(_packagedElements, XmlHelper.UmlStructure.Package);
            }
        }

        /// <summary>
        /// Internal switch property for <see cref="Profiles"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlProfile>? _profiles;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlProfile"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlProfile>? Profiles => _profiles;

        /// <summary>
        /// Internal switch property for <see cref="Packages"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlPackage>? _packages;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlPackage"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlPackage>? Packages => _packages;

        /// <inheritdoc cref="UmlProfileApplication"/>
        [XmlElement(XmlHelper.XmiStructure.PROFILE_APPLICATION, Namespace = "")]
        public UmlProfileApplication? ProfileApplication { get; set; }
    }
}