using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents <c>&lt;ownedRule /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_RULE, Namespace = "")]
    public class OwnedRule : XmiElement
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
        public Specification? Specification { get; set; }
    }
}