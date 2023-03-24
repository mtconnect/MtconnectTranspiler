using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlPackage : PackagedElement
    {
        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Represents element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Enumeration' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Stereotype' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Extension' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public XmlElement[]? PackagedElements { get; set; }

        [XmlIgnore]
        private PackagedElementCollection<UmlExtension> _extensions;
        [XmlIgnore]
        public PackagedElementCollection<UmlExtension> Extensions => _extensions ??= PackagedElementCollection<UmlExtension>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Extension);

        [XmlIgnore]
        private PackagedElementCollection<UmlStereotype> _stereotypes;
        [XmlIgnore]
        public PackagedElementCollection<UmlStereotype> Stereotypes => _stereotypes ??= PackagedElementCollection<UmlStereotype>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Stereotype);

        [XmlIgnore]
        private PackagedElementCollection<UmlClass> _classes;
        [XmlIgnore]
        public PackagedElementCollection<UmlClass> Classes => _classes ??= PackagedElementCollection<UmlClass>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Class);

        [XmlIgnore]
        private PackagedElementCollection<UmlEnumeration> _enumerations;
        [XmlIgnore]
        public PackagedElementCollection<UmlEnumeration> Enumerations => _enumerations ??= PackagedElementCollection<UmlEnumeration>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Enumeration);

        [XmlIgnore]
        private PackagedElementCollection<UmlPackage> _packages;
        [XmlIgnore]
        public PackagedElementCollection<UmlPackage> Packages => _packages ??= PackagedElementCollection<UmlPackage>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Package);

        [XmlIgnore]
        private PackagedElementCollection<UmlDataType> _dataTypes;
        [XmlIgnore]
        public PackagedElementCollection<UmlDataType> DataTypes => _dataTypes ??= PackagedElementCollection<UmlDataType>.Deserialize(PackagedElements, XmlHelper.UmlStructure.DataType);

        //// TODO: Add xmi:Extension

    }
}