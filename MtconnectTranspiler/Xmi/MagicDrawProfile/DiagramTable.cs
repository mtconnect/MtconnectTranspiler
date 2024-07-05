using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:DiagramTable /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MagicDrawProfileStructure.DIAGRAM_TABLE, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
    public class DiagramTable : ProfileElement
    {
        /// <summary>
        /// <c>base_Diagram</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.baseDiagram, Namespace = "")]
        public string? BaseDiagram { get; set; }

        /// <summary>
        /// <c>showDetailedColumnName</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showDetailedColumnName, Namespace = "")]
        public string? ShowDetailedColumnName { get; set; }

        /// <summary>
        /// <c>typesIncludeSubtypes</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.typesIncludeSubtypes, Namespace = "")]
        public string? TypesIncludeSubtypes { get; set; }

        /// <summary>
        /// <c>displayMode</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.displayMode, Namespace = "")]
        public string? DisplayMode { get; set; }

        /// <summary>
        /// <c>showElementNumber</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showElementNumber, Namespace = "")]
        public string? ShowElementNumber { get; set; }

        /// <summary>
        /// <c>showColumnIcons</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showColumnIcons, Namespace = "")]
        public string? ShowColumnIcons { get; set; }

        /// <summary>
        /// <c>showScopeAsRoot</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showScopeAsRoot, Namespace = "")]
        public string? ShowScopeAsRoot { get; set; }

        /// <summary>
        /// <c>showScope</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showScope, Namespace = "")]
        public string? ShowScope { get; set; }

        /// <summary>
        /// <c>showFilter</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showFilter, Namespace = "")]
        public string? ShowFilter { get; set; }

        /// <summary>
        /// <c>showElementType</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showElementType, Namespace = "")]
        public string? ShowElementType { get; set; }

        /// <summary>
        /// <c>additionalElements</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.additionalElements, Namespace = "")]
        public string? AdditionalElements { get; set; }

        /// <summary>
        /// <c>rowElements</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.ROW_ELEMENTS, Namespace = "")]
        public string[]? RowElements { get; set; }

        /// <summary>
        /// <c>sort</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.SORT, Namespace = "")]
        public string[]? Sorts { get; set; }
    }
}
