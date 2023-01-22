using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:extensible /&gt;</c>
    /// </summary>
    public class Extensible : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseEnumeration, Namespace = "")]
        public string BaseEnumeration { get; set; }
    }
}