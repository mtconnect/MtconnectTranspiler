using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c>
    /// </summary>
    [Serializable, XmlType(Namespace = XmlHelper.UmlNamespace), XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    public class UmlComment : OwnedComment
    {
        public override string Type => "uml:Comment";

    }
}