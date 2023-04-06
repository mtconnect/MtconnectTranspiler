using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:AssociationClass'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlAssociationClass : UmlClass
    {
        /// <summary>
        /// Collection of <inheritdoc cref="MemberEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
        public MemberEnd[]? MemberEnds { get; set; }
    }
}