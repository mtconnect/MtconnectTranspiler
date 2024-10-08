﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:Package'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlPackage : PackagedElement
    {
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        private XmlElement[]? _packagedElements;
        /// <summary>
        /// Represents <c>&lt;packagedElement /&gt;</c> element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Enumeration' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Stereotype' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Extension' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Association' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:AssociationClass' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XmlAnyElement(XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
        public XmlElement[]? PackagedElements
        {
            get { return _packagedElements; }
            set
            {
                _packagedElements = value;
                _extensions = PackagedElementCollection<UmlExtension>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Extension);
                _stereotypes = PackagedElementCollection<UmlStereotype>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Stereotype);
                _classes = PackagedElementCollection<UmlClass>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Class);
                _enumerations = PackagedElementCollection<UmlEnumeration>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Enumeration);
                _packages = PackagedElementCollection<UmlPackage>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Package);
                _dataTypes = PackagedElementCollection<UmlDataType>.Deserialize(PackagedElements, XmlHelper.UmlStructure.DataType);
                _associations = PackagedElementCollection<UmlAssociation>.Deserialize(PackagedElements, XmlHelper.UmlStructure.Association);
                _associationClasses = PackagedElementCollection<UmlAssociationClass>.Deserialize(PackagedElements, XmlHelper.UmlStructure.AssociationClass);
            }
        }

        /// <summary>
        /// Internal switch property for <see cref="Extensions"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlExtension>? _extensions;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlExtension"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlExtension>? Extensions => _extensions;

        /// <summary>
        /// Internal switch property for <see cref="Stereotypes"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlStereotype>? _stereotypes;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlStereotype"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlStereotype>? Stereotypes => _stereotypes;

        /// <summary>
        /// Internal switch property for <see cref="Classes"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlClass>? _classes;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlClass"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlClass>? Classes => _classes;
        /// <summary>
        /// Internal switch property for <see cref="Enumerations"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlEnumeration>? _enumerations;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlEnumeration"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlEnumeration>? Enumerations => _enumerations;

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
        /// Internal switch property for <see cref="DataTypes"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlDataType>? _dataTypes;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlDataType"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlDataType>? DataTypes => _dataTypes;

        /// <summary>
        /// Internal switch property for <see cref="Associations"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlAssociation>? _associations;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlAssociation"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlAssociation>? Associations => _associations;

        /// <summary>
        /// Internal switch property for <see cref="AssociationClasses"/>.
        /// </summary>
        [XmlIgnore]
        private PackagedElementCollection<UmlAssociationClass>? _associationClasses;
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlAssociationClass"/>
        /// </summary>
        [XmlIgnore]
        public PackagedElementCollection<UmlAssociationClass>? AssociationClasses => _associationClasses;

        //// TODO: Add xmi:Extension

    }
}