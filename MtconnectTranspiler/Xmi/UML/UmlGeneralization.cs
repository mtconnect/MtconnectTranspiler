using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
    public class UmlGeneralization : Generalization
    {
        /// <summary>
        /// Represents the <c>general</c> attribute in a <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.GENERAL)]
        public string General { get; set; }
    }
}