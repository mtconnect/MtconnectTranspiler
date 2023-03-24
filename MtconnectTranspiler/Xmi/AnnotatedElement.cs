using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;annotatedElement /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.ANNOTATED_ELEMENT, Namespace = "")]
    public class AnnotatedElement
    {
        /// <summary>
        /// Represents the <c>xmi:idref</c> attribute.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string IdRef { get; set; }
    }
}