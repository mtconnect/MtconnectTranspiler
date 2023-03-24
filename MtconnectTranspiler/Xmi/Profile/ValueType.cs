using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;Profile:valueType /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ProfileStructure.VALUE_TYPE, Namespace = XmlHelper.ProfileNamespace)]
    public class ValueType : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseClass, Namespace = "")]
        public string BaseClass { get; set; }
    }
}