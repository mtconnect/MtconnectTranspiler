using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;assocation /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.ASSOCIATION, Namespace = "")]
    public class Association
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.href, Namespace = "")]
        public string Href { get; set; }
    }
}