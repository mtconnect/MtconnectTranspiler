using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;specification /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
    [XmlInclude(typeof(UmlOpaqueExpression))]
    public class Specification : XmiElement
    {
        /// <summary>
        /// <c>body</c> attribute
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.BODY, Namespace = "")]
        public string? Body { get; set; }

        /// <summary>
        /// <c>language</c> attribute
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.LANGUAGE, Namespace = "")]
        public string? Language { get; set; }
    }
}