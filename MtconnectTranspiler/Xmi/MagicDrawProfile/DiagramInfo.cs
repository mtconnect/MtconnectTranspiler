using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:DiagramInfo /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MagicDrawProfileStructure.DIAGRAM_INFO, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
    public class DiagramInfo : ProfileElement
    {
        /// <summary>
        /// <c>base_Diagram</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.baseDiagram, Namespace = "")]
        public string? BaseDiagram { get; set; }

        /// <summary>
        /// <c>Creation_date</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.creationDate, Namespace = "")]
        public string? CreationDate { get; set; }

        /// <summary>
        /// <c>Modification_date</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.modificationDate, Namespace = "")]
        public string? ModificationDate { get; set; }

        /// <summary>
        /// <c>Author</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.author, Namespace = "")]
        public string? Author { get; set; }

        /// <summary>
        /// <c>Last_modified_by</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.lastModifiedBy, Namespace = "")]
        public string? LastModifiedBy { get; set; }
    }
}
