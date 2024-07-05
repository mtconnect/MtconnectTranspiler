namespace MtconnectTranspiler.Contracts
{
    internal static class XmlHelper
    {
        public const string XmiNamespace = "http://www.omg.org/spec/XMI/20131001";
        public const string UmlNamespace = "http://www.omg.org/spec/UML/20131001";
        public const string ProfileNamespace = "http://www.magicdraw.com/schemas/Profile.xmi";
        public const string StandardProfileNamespace = "http://www.omg.org/spec/UML/20131001/StandardProfile";
        public const string Validation_ProfileNamespace = "http://www.magicdraw.com/schemas/Validation_Profile.xmi";
        public const string Dependency_Matrix_ProfileNamespace = "http://www.magicdraw.com/schemas/Dependency_Matrix_Profile.xmi";
        public const string Concept_Modeling_ProfileNamespace = "http://www.magicdraw.com/schemas/Concept_Modeling_Profile.xmi";
        public const string DSL_CustomizationNamespace = "http://www.magicdraw.com/schemas/DSL_Customization.xmi";
        public const string SysMlNamespace = "http://www.omg.org/spec/SysML/20150709/SysML";
        public const string MagicDraw_ProfileNamespace = "http://www.omg.org/spec/UML/20131001/MagicDrawProfile";
        public const string Ccm_Internal_Implementation_ProfileNamespace = "http://www.magicdraw.com/schemas/CCM_Internal_Implementation_Profile.xmi";
        public const string Md_Customization_for_SysML__additional_stereotypesNamespace = "http://www.magicdraw.com/spec/Customization/180/SysML";
        public const string SimulationProfileNamespace = "http://www.magicdraw.com/schemas/SimulationProfile.xmi";

        public static class MDCustomizationForSysMLAdditionalStereoTypes
        {
            #region XML Tags
            public const string VALUE_PROPERTY = "ValueProperty";
            public const string PART_PROPERTY = "PartProperty";
            public const string REFERENCE_PROPERTY = "ReferenceProperty";
            public const string CONSTRAINT_PROPERTY = "ConstraintProperty";
            public const string CONSTRAINT_PARAMETER = "ConstraintParameter";
            #endregion

            #region XML Attributes
            public const string baseProperty = "base_Property";
            public const string basePort = "base_Port";
            #endregion
        }

        public static class ConceptModelingProfileStructure
        {
            #region XML Tags
            public const string LITERAL_ANNOTATION = "Literal_Annotation";
            public const string RESTRICTION = "Restriction";
            public const string EQUIVALENT_CLASS = "Equivalent_Class";
            public const string FUNCTIONAL = "Functional";
            public const string RESOURCE = "Resource";
            public const string DISJOINT_WITH = "Disjoint_With";
            public const string ANYTHING = "Anything";
            #endregion

            #region XML Attributes
            public const string baseComment = "base_Comment";
            public const string baseClass = "base_Class";
            public const string baseProperty = "base_Property";
            public const string baseGeneralization = "base_Generalization";
            public const string IRI = "IRI";
            public const string baseDependency = "base_Dependency";
            #endregion
        }

        public static class MagicDrawProfileStructure
        {
            #region XML Tags
            public const string ADDITIONAL_ELEMENT_IMPORT = "additionalElementImport";
            public const string ADDITIONAL_PACKAGE_IMPORT = "additionalPackageImport";
            public const string DIAGRAM_INFO = "DiagramInfo";
            public const string DIAGRAM_TABLE = "DiagramTable";
            public const string CUSTOM_SORT = "CustomSort";
            public const string ROW_ELEMENTS = "rowElements";
            public const string SORT = "sort";
            #endregion

            #region XML Attributes
            public const string baseElementImport = "base_ElementImport";
            public const string basePackageImport = "base_PackageImport";
            public const string treatAsAuxiliaryInOwningProject = "treatAsAuxiliaryInOwningProject";
            public const string baseDiagram = "base_Diagram";
            public const string author = "Author";
            public const string creationDate = "Creation_date";
            public const string modificationDate = "Modification_date";
            public const string lastModifiedBy = "Last_modified_by";
            public const string baseElement = "base_Element";
            public const string sortPriority = "sortPriority";
            public const string showDetailedColumnName = "showDetailedColumnName";
            public const string typesIncludeSubtypes = "typesIncludeSubtypes";
            public const string displayMode = "displayMode";
            public const string showElementNumber = "showElementNumber";
            public const string showColumnIcons = "showColumnIcons";
            public const string showScopeAsRoot = "showScopeRoot";
            public const string showScope = "showScope";
            public const string showFilter = "showFilter";
            public const string showElementType = "showElementType";
            public const string additionalElements = "additionalElements";
            #endregion
        }

        public static class ProfileStructure
        {
            #region XML Tags
            public const string NORMATIVE = "normative";
            public const string DEPRECATED = "deprecated";
            public const string EXTENSIBLE = "extensible";
            public const string INFORMATIVE = "informative";
            public const string OBSERVES = "observes";
            public const string ORGANIZER = "organizer";
            public const string VALUE_TYPE = "valueType";
            #endregion
        }

        public static class XmiStructure
        {
            #region XML Tags
            public const string FILE_PART = "filePart";
            public const string PACKAGED_ELEMENT = "packagedElement";
            public const string PACKAGE_IMPORT = "packageImport";
            public const string OWNED_COMMENT = "ownedComment";
            public const string OWNED_END = "ownedEnd";
            public const string OWNED_LITERAL = "ownedLiteral";
            public const string OWNED_RULE = "ownedRule";
            public const string OWNED_ATTRIBUTE = "ownedAttribute";
            public const string OWNED_OPERATION = "ownedOperation";
            public const string OWNED_PARAMETER = "ownedParameter";
            public const string BODY = "body";
            public const string SPECIFICATION = "specification";
            public const string LANGUAGE = "language";
            public const string GENERALIZATION = "generalization";
            public const string GENERAL = "general";
            public const string TYPE = "type";
            public const string ASSOCIATION = "association";
            public const string DEFAULT_VALUE = "defaultValue";
            public const string REDEFINED_PROPERTY = "redefinedProperty";
            public const string SUBSETTED_PROPERTY = "subsettedProperty";
            public const string MODEL = "Model";
            public const string ANNOTATED_ELEMENT = "annotatedElement";
            public const string LOWER_VALUE = "lowerValue";
            public const string UPPER_VALUE = "upperValue";
            public const string EXTENSION = "Extension";
            public const string MODEL_EXTENSION = "modelExtension";
            public const string CONSTRAINED_ELEMENT = "constrainedElement";
            public const string MEMBER_END = "memberEnd";
            public const string METAMODEL_REFERENCE = "metamodelReference";
            public const string DOCUMENTATION = "Documentation";
            public const string EXPORTER = "exporter";
            public const string EXPORTER_VERSION = "exporterVersion";
            #endregion

            #region XML Attributes
            public const string header = "header";
            public const string visibility = "visibility";
            public const string isQuery = "isQuery";
            public const string isAbstract = "isAbstract";
            public const string aggregation = "aggregation";
            public const string id = "id";
            public const string idRef = "idref";
            public const string type = "type";
            public const string name = "name";
            public const string version = "version";
            public const string introduced = "introduced";
            public const string baseElement = "base_Element";
            public const string baseClass = "base_Class";
            public const string baseComment = "base_Comment";
            public const string baseEnumeration = "base_Enumeration";
            public const string baseAssociation = "base_Association";
            public const string importedPackage = "importedPackage";
            public const string href = "href";
            public const string association = "association";
            public const string instance = "instance";
            public const string isStatic = "isStatic";
            public const string isReadOnly = "isReadOnly";
            public const string value = "value";
            public const string extender = "extender";
            #endregion
        }

        public static class SysMLStructure
        {
            #region XML Tags
            public const string BLOCK = "Block";
            public const string VALUE_TYPE = "ValueType";
            public const string BINDING_CONNECTOR = "BindingConnector";
            public const string NESTED_CONNECTOR_END = "NestedConnectorEnd";
            #endregion

            #region XML Attributes
            public const string baseClass = "base_Class";
            public const string baseElement = "base_Element";
            public const string baseDataType = "base_DataType";
            public const string baseConnector = "base_Connector";
            public const string baseConnectorEnd = "base_ConnectorEnd";
            public const string propertyPath = "propertyPath";
            #endregion
        }

        public class UmlStructure
        {
            #region UML xmi:type options
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Enumeration' /&gt;</c>
            /// </summary>
            public const string Enumeration = "uml:Enumeration";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c>
            /// </summary>
            public const string DataType = "uml:DataType";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c>
            /// </summary>
            public const string Class = "uml:Class";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Stereotype' /&gt;</c>
            /// </summary>
            public const string Stereotype = "uml:Stereotype";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Extension' /&gt;</c>
            /// </summary>
            public const string Extension = "uml:Extension";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c>
            /// </summary>
            public const string Package = "uml:Package";
            /// <summary>
            /// <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c>
            /// </summary>
            public const string Comment = "uml:Comment";
            /// <summary>
            /// <c>&lt;ownedRule xmi:type='uml:Constraint' /&gt;</c>
            /// </summary>
            public const string Constraint = "uml:Constraint";
            /// <summary>
            /// <c>&lt;ownedLiteral xmi:type='uml:EnumerationLiteral' /&gt;</c>
            /// </summary>
            public const string EnumerationLiteral = "uml:EnumerationLiteral";
            /// <summary>
            /// <c>&lt;ownedEnd xmi:type='uml:ExtensionEnd' /&gt;</c>
            /// </summary>
            public const string ExtensionEnd = "uml:ExtensionEnd";
            /// <summary>
            /// <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c>
            /// </summary>
            public const string Generalization = "uml:Generalization";
            /// <summary>
            /// <c>&lt;defaultValue xmi:type='uml:InstanceValue' /&gt;</c>
            /// </summary>
            public const string InstanceValue = "uml:InstanceValue";
            /// <summary>
            /// <c>&lt;defaultValue xmi:type='uml:LiteralString' /&gt;</c>
            /// </summary>
            public const string LiteralString = "uml:LiteralString";
            /// <summary>
            /// <c>&lt;uml:Model xmi:type='uml:Model' /&gt;</c>
            /// </summary>
            public const string Model = "uml:Model";
            /// <summary>
            /// <c>&lt;specification xmi:type='uml:OpaqueExpression' /&gt;</c>
            /// </summary>
            public const string OpaqueExpression = "uml:OpaqueExpression";
            /// <summary>
            /// <c>&lt;packageImport xmi:type='uml:PackageImport' /&gt;</c>
            /// </summary>
            public const string PackageImport = "uml:PackageImport";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:PrimitiveType' /&gt;</c>
            /// </summary>
            public const string PrimitiveType = "uml:PrimitiveType";
            /// <summary>
            /// <c>&lt;packagedElement xmi:type='uml:Profile' /&gt;</c>
            /// </summary>
            public const string Profile = "uml:Profile";
            /// <summary>
            /// <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c>
            /// </summary>
            public const string Property = "uml:Property";
            /// <summary>
            /// <c>&lt;ownedAttribute xmi:type='uml:AssociationClass' /&gt;</c>
            /// </summary>
            public const string AssociationClass = "uml:AssociationClass";
            /// <summary>
            /// <c>&lt;ownedAttribute xmi:type='uml:Association' /&gt;</c>
            /// </summary>
            public const string Association = "uml:Association";
            #endregion
        }
    }
}
