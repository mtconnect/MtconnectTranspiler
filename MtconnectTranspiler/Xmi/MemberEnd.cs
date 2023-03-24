using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;memberEnd /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MEMBER_END, Namespace = "")]
    public class MemberEnd : XmiElement
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}