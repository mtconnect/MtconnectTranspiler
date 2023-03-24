using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;ownedParameter /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_PARAMETER, Namespace = "")]
    public class OwnedParameter : XmiElement
    {
        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public OwnedComment[]? Comments { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
        public DefaultValue? DefaultValue { get; set; }
    }
}