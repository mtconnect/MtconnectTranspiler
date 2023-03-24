using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackagedElement"/> where <c>xmi:type='uml:Class'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlClass : PackagedElement
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.Class;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlComment"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlProperty"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_ATTRIBUTE, Namespace = "")]
        public UmlProperty[]? Properties { get; set; }

        /// <summary>
        /// <c>isAbstract</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        private bool _isAbstract { get; set; }
        /// <inheritdoc cref="_isAbstract"/>
        public bool IsAbstract => _isAbstract;

        /// <summary>
        /// Collection of <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlConstraint"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_RULE)]
        public UmlConstraint[]? Constraints { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UML.UmlGeneralization"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization? Generalization { get; set; }
    }
}