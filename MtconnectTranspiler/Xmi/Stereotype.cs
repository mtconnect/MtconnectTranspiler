using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;stereotype /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.STEREOTYPE, Namespace = "")]
    public class Stereotype
    {
        /// <summary>
        /// <c>name</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public string? Name { get; set; }

        /// <summary>
        /// <c>stereotypeHREF</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.stereotypeHref, Namespace = "")]
        public string? StereotypeHref { get; set; }
    }
}