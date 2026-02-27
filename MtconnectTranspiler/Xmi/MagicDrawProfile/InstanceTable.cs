using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:InstanceTable /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MagicDrawProfileStructure.INSTANCE_TABLE, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
    public class InstanceTable : ProfileElement
    {
        /// <summary>
        /// <c>base_Diagram</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.baseDiagram, Namespace = "")]
        public string? BaseDiagram { get; set; }

        /// <summary>
        /// <c>showColumnIcons</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showColumnIcons, Namespace = "")]
        public string? ShowColumnIcons { get; set; }

        /// <summary>
        /// <c>classifiers</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.classifiers, Namespace = "")]
        public string? Classifiers { get; set; }

        /// <summary>
        /// <c>showFilter</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showFilter, Namespace = "")]
        public string? ShowFilter { get; set; }

        /// <summary>
        /// <c>scope</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.scope, Namespace = "")]
        public string? Scope { get; set; }

        /// <summary>
        /// <c>showUnitsOnValues</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showUnitsOnValues, Namespace = "")]
        public string? ShowUnitsOnValues { get; set; }

        /// <summary>
        /// <c>includeSubtypesOfRowTypes</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.includeSubtypesOfRowTypes, Namespace = "")]
        public string? IncludeSubtypesOfRowTypes { get; set; }

        /// <summary>
        /// <c>showDetailedColumnName</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showDetailedColumnName, Namespace = "")]
        public string? ShowDetailedColumnName { get; set; }

        /// <summary>
        /// <c>showElementType</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showElementType, Namespace = "")]
        public string? ShowElementType { get; set; }

        /// <summary>
        /// <c>displayMode</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.displayMode, Namespace = "")]
        public string? DisplayMode { get; set; }

        /// <summary>
        /// <c>rowsOrder</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.rowsOrder, Namespace = "")]
        public string? RowsOrder { get; set; }

        /// <summary>
        /// <c>showScope</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showScope, Namespace = "")]
        public string? ShowScope { get; set; }

        /// <summary>
        /// <c>showScopeAsRoot</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showScopeAsRoot, Namespace = "")]
        public string? ShowScopeAsRoot { get; set; }

        /// <summary>
        /// <c>showElementNumber</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.showElementNumber, Namespace = "")]
        public string? ShowElementNumber { get; set; }

        /// <summary>
        /// <c>includeCustomTypesOfRowTypes</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.includeCustomTypesOfRowTypes, Namespace = "")]
        public string? IncludeCustomTypesOfRowTypes { get; set; }

        /// <summary>
        /// <c>hideColumns</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.HIDE_COLUMNS, Namespace = "")]
        public string[]? HideColumns { get; set; }

        /// <summary>
        /// <c>columnIds</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.COLUMN_IDS, Namespace = "")]
        public string[]? ColumnIds { get; set; }

        /// <summary>
        /// <c>rowElements</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.ROW_ELEMENTS, Namespace = "")]
        public string[]? RowElements { get; set; }

        /// <summary>
        /// <c>expandedRows</c> elements
        /// </summary>
        [XmlElement(ElementName = XmlHelper.MagicDrawProfileStructure.EXPANDED_ROWS, Namespace = "")]
        public string[]? ExpandedRows { get; set; }
    }
}
