using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;packageElement /&gt;</c>.
    /// </summary>
    [Serializable, XmlType(AnonymousType = true, Namespace = ""), XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class PackagedElement : XmiElement {}
}