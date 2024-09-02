using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.SysML
{
    /// <summary>
    /// <c>&lt;sysml:NestedConnectorEnd /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.SysMLStructure.NESTED_CONNECTOR_END, Namespace = XmlHelper.SysMlNamespace)]
    public class SysMLNestedConnectorEnd : ProfileElement
    {
        /// <summary>
        /// <c>base_ConnectorEnd</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.baseConnectorEnd, Namespace = "")]
        public string? BaseConnectorEnd { get; set; }

        /// <summary>
        /// <c>propertyPath</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.propertyPath, Namespace = "")]
        public string? propertyPath { get; set; }
    }
}
