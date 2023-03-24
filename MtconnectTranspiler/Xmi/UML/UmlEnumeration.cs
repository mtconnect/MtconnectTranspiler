using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement" /> where <c>xmi:type='uml:Enumeration'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlEnumeration : PackagedElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Enumeration;

        /// <summary>
        /// Collection of <inheritdoc cref="UmlEnumerationLiteral"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_LITERAL, Namespace = "")]
        public UmlEnumerationLiteral[]? Items { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="UmlGeneralization"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}