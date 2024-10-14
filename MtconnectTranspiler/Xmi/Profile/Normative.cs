using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// <c>&lt;Profile:normative /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ProfileStructure.NORMATIVE, Namespace = XmlHelper.ProfileNamespace)]
    public class Normative : ProfileElement
    {
        /// <summary>
        /// <c>base_Element</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseElement, Namespace = "")]
        public string? BaseElement { get; set; }

        /// <summary>
        /// <c>introduced</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.introduced, Namespace = "")]
        public string? Introduced { get; set; }

        /// <summary>
        /// <c>deprecated</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.deprecated, Namespace = "")]
        public string? Deprecated { get; set; }

        /// <summary>
        /// <c>updated</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.updated, Namespace = "")]
        public string[]? Updated { get; set; }
    }
}