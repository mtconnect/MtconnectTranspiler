using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;type /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.TYPE, Namespace = "")]
    public class Type : XmiElement
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.href, Namespace = "")]
        public string Href { get; set; }
    }
}