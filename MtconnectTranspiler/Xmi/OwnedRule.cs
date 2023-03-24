using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;ownedRule /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_RULE, Namespace = "")]
    public class OwnedRule : XmiElement
    {
        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.Specification"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
        public Specification? Specification { get; set; }
    }
}