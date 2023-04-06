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

        // TODO: Add <ownedEnd xmi:type='uml:Property' />
    }
}