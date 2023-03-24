using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;redefinedProperty /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.REDEFINED_PROPERTY, Namespace = "")]
    public class RedefinedProperty
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? IdRef { get; set; }
    }
}