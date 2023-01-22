using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:x /&gt;</c>
    /// </summary>
    public abstract class ProfileElement
    {
        /// <summary>
        /// Unique ID within the XMI.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Id { get; set; }
    }
}