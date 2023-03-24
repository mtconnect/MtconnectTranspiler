using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;
using System;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:PrimitiveType' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlPrimitiveType : PackagedElement
    {
        public override string Type => XmlHelper.UmlStructure.PrimitiveType;
    }
}