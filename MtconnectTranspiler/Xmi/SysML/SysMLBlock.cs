using MtconnectTranspiler.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.SysML
{
    /// <summary>
    /// <c>&lt;sysml:Block /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.SysMLStructure.BLOCK, Namespace = XmlHelper.SysMlNamespace)]
    public class SysMLBlock : ProfileElement
    {
        /// <summary>
        /// <c>base_Element</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.baseElement, Namespace = "")]
        public string? BaseElement { get; set; }

        /// <summary>
        /// <c>base_Class</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.baseClass, Namespace = "")]
        public string? BaseClass { get; set; }

        /// <summary>
        /// <c>isEncapsulated</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.isEncapsulated, Namespace = "")]
        public string? IsEncapsulated { get; set; }
    }
}
