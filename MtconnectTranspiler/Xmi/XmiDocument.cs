using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>xmi:XMI</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = "XMI", Namespace = XmlHelper.XmiNamespace)]
    public class XmiDocument
    {
        public XmlDocument SourceDocument { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.XmiDocumentation"/>
        /// </summary>
        public XmiDocumentation? Documentation { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlModel"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.MODEL, Namespace = XmlHelper.UmlNamespace)]
        public UmlModel? Model { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Normative"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.NORMATIVE, Namespace = XmlHelper.ProfileNamespace)]
        public Normative[]? NormativeIntroductions { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.Profile.Deprecated"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.ProfileStructure.DEPRECATED, Namespace = XmlHelper.ProfileNamespace)]
        public Deprecated[]? Deprecations { get; set; }
    }
}