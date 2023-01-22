using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:valueType /&gt;</c>
    /// </summary>
    public class ValueType : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseClass, Namespace = "")]
        public string BaseClass { get; set; }
    }
}