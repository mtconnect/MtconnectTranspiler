using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;appliedProfile /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.APPLIED_PROFILE, Namespace = "")]
    public class AppliedProfile
    {
        /// <summary>
        /// <c>href</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.href, Namespace = "")]
        public string? Href { get; set; }

        /// <inheritdoc cref="XmiExtension"/>
        [XmlElement(ElementName = XmlHelper.XmiStructure.EXTENSION, Namespace = XmlHelper.XmiNamespace)]
        public XmiExtension? Extension { get; set; }
    }
}