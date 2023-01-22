using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;ownedLiteral /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL, Namespace = "")]
    public class OwnedLiteral : XmiElement { }
}