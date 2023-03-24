using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents a <c>&lt;generalization /&gt;</c> element.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
    public class Generalization : XmiElement
    {
        // TODO: Add general, general#href
    }
}