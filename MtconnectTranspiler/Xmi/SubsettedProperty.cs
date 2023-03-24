using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents a <c>&lt;subsettedProperty /&gt;</c> element.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.SUBSETTED_PROPERTY, Namespace = "")]
    public class SubsettedProperty
    {
        /// <summary>
        /// Represents the <c>xmi:idref</c> attribute in an element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public virtual string IdRef { get; set; }
    }
}