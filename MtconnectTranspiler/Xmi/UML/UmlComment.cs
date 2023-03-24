using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedComment"/> where <c>xmi:type='uml:Comment'</c>
    /// </summary>
    [Serializable, XmlType(Namespace = XmlHelper.UmlNamespace), XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
    public class UmlComment : OwnedComment
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Comment;

    }
}