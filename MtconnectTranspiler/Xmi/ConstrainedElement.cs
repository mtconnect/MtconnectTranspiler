using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents <c>&lt;constrainedElement /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.CONSTRAINED_ELEMENT, Namespace = "")]
    public class ConstrainedElement : XmiElement
    {
        /// <summary>
        /// Represents <c>xmi:idref</c> in <c>&lt;constrainedElement /&gt;</c>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}