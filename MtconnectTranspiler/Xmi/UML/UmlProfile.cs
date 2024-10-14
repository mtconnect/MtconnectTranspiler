using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:Profile'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlProfile : PackagedElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Profile;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlPackageImport"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
        public UmlPackageImport[]? Imports { get; set; }

        private XmlElement[]? _packagedElements;
        /// <summary>
        /// Represents <c>&lt;packagedElement /&gt;</c> element(s):
        /// <list type="bullet">
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
                _packages = PackagedElementCollection<UmlPackage>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Package);
            }
        }

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

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.MetamodelReference"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.METAMODEL_REFERENCE, Namespace = "")]
        public MetamodelReference? MetaModelReference { get; set; }

        // TODO: Add appliedProfile
    }
}