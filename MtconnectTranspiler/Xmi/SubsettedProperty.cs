using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;subsettedProperty /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.SUBSETTED_PROPERTY, Namespace = "")]
    public class SubsettedProperty
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? IdRef { get; set; }
    }
}