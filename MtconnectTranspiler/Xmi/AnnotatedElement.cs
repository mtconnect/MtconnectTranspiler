using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;annotatedElement /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.ANNOTATED_ELEMENT, Namespace = "")]
    public class AnnotatedElement
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}