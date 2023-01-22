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

        public static class XmiStructure
        {
            #region XML Tags
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
            #endregion

            #region XML Attributes
            public const string visibility = "visibility";
            public const string isQuery = "isQuery";
            public const string isAbstract = "isAbstract";
            public const string aggregation = "aggregation";
            public const string id = "id";
            public const string type = "type";
            public const string name = "name";
            public const string version = "version";
            public const string baseElement = "base_Element";
            public const string baseClass = "base_Class";
            public const string baseComment = "base_Comment";
            public const string baseEnumeration = "base_Enumeration";
            public const string baseAssociation = "base_Association";
            public const string importedPackage = "importedPackage";
            public const string href = "href";
            public const string association = "association";
            #endregion
        }
    }
}
