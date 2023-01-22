using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents <c>&lt;packagedElement /&gt;</c>
    /// </summary>
    [Serializable, XmlType(AnonymousType = true, Namespace = ""), XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class PackagedElement : XmiElement {}
}