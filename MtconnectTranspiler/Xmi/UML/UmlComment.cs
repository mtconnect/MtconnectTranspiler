using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    public class UmlComment : OwnedComment
    {
        [XPath("./annotatedElement@xmi:idref")]
        public string AnnotatedElement { get; set; }
    }
}