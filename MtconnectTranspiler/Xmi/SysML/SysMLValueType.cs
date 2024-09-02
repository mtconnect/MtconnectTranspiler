using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.SysML
{
    /// <summary>
    /// <c>&lt;sysml:ValueType /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.SysMLStructure.VALUE_TYPE, Namespace = XmlHelper.SysMlNamespace)]
    public class SysMLValueType : ProfileElement
    {
        /// <summary>
        /// <c>base_DataType</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.SysMLStructure.baseDataType, Namespace = "")]
        public string? BaseDataType { get; set; }
    }
}
