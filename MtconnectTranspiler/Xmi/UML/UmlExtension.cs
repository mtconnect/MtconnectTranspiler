using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:Extension'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlExtension : PackagedElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Extension;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.MemberEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
        public MemberEnd[]? MemberEnds { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlExtensionEnd"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_END, Namespace = "")]
        public UmlExtensionEnd? End { get; set; }

        /// <summary>
        /// Collection of <c>&lt;stereotype /&gt;</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.STEREOTYPE, Namespace = "")]
        public Stereotype[]? Stereotypes { get; set; }

        /// <summary>
        /// Collection of <c>&lt;tag /&gt;</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.TAG, Namespace = "")]
        public Tag[]? Tags { get; set; }

        /// <summary>
        /// Child element not handled in deserialization.
        /// </summary>
        [XmlAnyElement]
        public object[]? AllChildElements { get; set; }
    }
}