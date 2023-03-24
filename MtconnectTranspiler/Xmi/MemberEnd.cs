using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents <c>&lt;memberEnd /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
    public class MemberEnd : XmiElement
    {
        /// <summary>
        /// Represents <c>xmi:idref</c> in <c>&lt;memberEnd /&gt;</c>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}