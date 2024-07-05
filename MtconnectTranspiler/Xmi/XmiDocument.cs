using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.ConceptModelingProfile;
using MtconnectTranspiler.Xmi.MagicDrawProfile;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.SysML;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>xmi:XMI</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = "XMI", Namespace = XmlHelper.XmiNamespace)]
    public class XmiDocument
    {
        [XmlIgnore]
        public Dictionary<string, object> IdCache { get; set; }

        public XmlDocument SourceDocument { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.XmiDocumentation"/>
        /// </summary>
        public XmiDocumentation? Documentation { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlModel"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.MODEL, Namespace = XmlHelper.UmlNamespace)]
        public UmlModel? Model { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.XmiExtension"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension[]? Extensions { get; set; }

        #region Profile
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Normative"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.NORMATIVE, Namespace = XmlHelper.ProfileNamespace)]
        public Normative[]? Introductions { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Deprecated"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.DEPRECATED, Namespace = XmlHelper.ProfileNamespace)]
        public Deprecated[]? Deprecations { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Informative"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.INFORMATIVE, Namespace = XmlHelper.ProfileNamespace)]
        public Informative[]? Updates { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Observes"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.OBSERVES, Namespace = XmlHelper.ProfileNamespace)]
        public Observes[]? Observations { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.ValueType"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.VALUE_TYPE, Namespace = XmlHelper.ProfileNamespace)]
        public Profile.ValueType[]? ValueTypes { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Extensible"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.EXTENSIBLE, Namespace = XmlHelper.ProfileNamespace)]
        public Profile.Extensible[]? Extensibilities { get; set; }
        #endregion

        #region Concept_Modeling_Profile
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.Anything"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.ANYTHING, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public Anything[]? Anythings { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.DisjointWith"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.DISJOINT_WITH, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public DisjointWith[]? DisjointsWith { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.EquivalentClass"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.EQUIVALENT_CLASS, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public EquivalentClass[]? EquivalentClasses { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.Functional"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.FUNCTIONAL, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public Functional[]? Functionals { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.LiteralAnnotation"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.LITERAL_ANNOTATION, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public LiteralAnnotation[]? LiteralAnnotations { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.Resource"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.RESOURCE, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public Resource[]? Resources { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.ConceptModelingProfile.Restriction"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ConceptModelingProfileStructure.RESTRICTION, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
        public Restriction[]? Restrictions { get; set; }
        #endregion

        #region MagicDraw_Profile
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MagicDrawProfile.AdditionalElementImport"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.ADDITIONAL_ELEMENT_IMPORT, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
        public AdditionalElementImport[]? AdditionalElementImports { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MagicDrawProfile.AdditionalPackageImport"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.ADDITIONAL_PACKAGE_IMPORT, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
        public AdditionalPackageImport[]? AdditionalPackageImports { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MagicDrawProfile.CustomSort"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.CUSTOM_SORT, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
        public CustomSort[]? CustomSorts { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MagicDrawProfile.DiagramInfo"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.DIAGRAM_INFO, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
        public DiagramInfo[]? DiagramInfos { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MagicDrawProfile.DiagramTable"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.DIAGRAM_TABLE, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
        public DiagramTable[]? DiagramTables { get; set; }
        #endregion

        #region MD_Customization_for_SysML__additional_stereotypes
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes.ValueProperty"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.VALUE_PROPERTY, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
        public MDCustomizationForSysMLAdditionalStereoTypes.ValueProperty[]? ValueProperties { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes.PartProperty"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.PART_PROPERTY, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
        public MDCustomizationForSysMLAdditionalStereoTypes.PartProperty[]? PartProperties { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes.ReferenceProperty"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.REFERENCE_PROPERTY, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
        public MDCustomizationForSysMLAdditionalStereoTypes.ReferenceProperty[]? ReferenceProperties { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes.ConstraintProperty"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.CONSTRAINT_PROPERTY, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
        public MDCustomizationForSysMLAdditionalStereoTypes.ConstraintProperty[]? ConstraintProperties { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes.ConstraintParameter"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.CONSTRAINT_PARAMETER, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
        public MDCustomizationForSysMLAdditionalStereoTypes.ConstraintParameter[]? ConstraintParameters { get; set; }
        #endregion

        #region SysML
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.SysML.SysMLBlock"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.SysMLStructure.BLOCK, Namespace = XmlHelper.SysMlNamespace)]
        public SysMLBlock[]? SysMLBlocks { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.SysML.SysMLValueType"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.SysMLStructure.VALUE_TYPE, Namespace = XmlHelper.SysMlNamespace)]
        public SysMLValueType[]? SysMLValueTypes { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.SysML.SysMLBindingConnector"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.SysMLStructure.BINDING_CONNECTOR, Namespace = XmlHelper.SysMlNamespace)]
        public SysMLBindingConnector[]? SysMLBindingConnectors { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.SysML.SysMLNestedConnectorEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.SysMLStructure.NESTED_CONNECTOR_END, Namespace = XmlHelper.SysMlNamespace)]
        public SysMLNestedConnectorEnd[]? SysMLNestedConnectorEnds { get; set; }
        #endregion

        [XmlAnyElement]
        public object[]? AllChildElements { get; set; }
    }
}