using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlDataType : PackagedElement
    {
        /// <summary>
        /// Represents the <c>isAbstract</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.isAbstract, Namespace = "")]
        private bool _isAbstract { get; set; }
        /// <inheritdoc cref="_isAbstract"/>
        public bool IsAbstract => _isAbstract;

        /// <summary>
        /// Represents the <c>visibility</c> attribute in a <c>&lt;ownedAttribute xmi:type='uml:Property' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        private string _visibility { get; set; } = "public";
        /// <inheritdoc cref="_visibility"/>
        public string Visibility => _visibility;

        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT, Namespace = "")]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Represents the <c>&lt;generalization xmi:type='uml:Generalization' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.GENERALIZATION, Namespace = "")]
        public UmlGeneralization[]? Generalization { get; set; }
    }
}