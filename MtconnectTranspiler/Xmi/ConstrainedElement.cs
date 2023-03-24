using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;constrainedElement /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.CONSTRAINED_ELEMENT, Namespace = "")]
    public class ConstrainedElement : XmiElement
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}