using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:Association'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlAssociation : PackagedElement
    {
        /// <summary>
        /// Collection of <inheritdoc cref="MemberEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
        public MemberEnd[]? MemberEnds { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment? SubComment { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="OwnedEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_END, Namespace = "")]
        public OwnedEnd[]? OwnedEnds { get; set; }
    }
}