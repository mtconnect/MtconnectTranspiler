using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.SysML
{
    /// <summary>
    /// <c>&lt;sysml:BindingConnector /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.SysMLStructure.BINDING_CONNECTOR, Namespace = XmlHelper.SysMlNamespace)]
    public class SysMLBindingConnector : ProfileElement
    {
        /// <summary>
        /// <c>base_Connector</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.baseConnector, Namespace = "")]
        public string? BaseConnector { get; set; }
    }
}
