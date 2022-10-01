namespace MtconnectTranspiler.Contracts
{
    internal static class XmlHelper
    {
        public const string XmiNamespace = "http://www.omg.org/spec/XMI/20131001";
        public const string UmlNamespace = "http://www.omg.org/spec/UML/20131001";

        public static class XmiStructure
        {
            #region XML Tags
            public const string PACKAGED_ELEMENT = "packagedElement";
            public const string OWNED_COMMENT = "ownedComment";
            public const string OWNED_LITERAL = "ownedLiteral";
            public const string OWNED_RULE = "ownedRule";
            public const string OWNED_ATTRIBUTE = "ownedAttribute";
            public const string OWNED_OPERATION = "ownedOperation";
            public const string OWNED_PARAMETER = "ownedParameter";
            public const string BODY = "body";
            public const string SPECIFICATION = "specification";
            public const string LANGUAGE = "language";
            #endregion

            #region XML Attributes
            public const string visibility = "visibility";
            public const string isQuery = "isQuery";
            public const string isAbstract = "isAbstract";
            public const string aggregation = "aggregation";
            public const string id = "id";
            public const string type = "type";
            public const string name = "name";
            #endregion
        }
    }
}
