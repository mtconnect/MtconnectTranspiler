using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    public abstract class XmiElement : IXmiElement
    {
        /// <summary>
        /// Unique ID within the XMI.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Id { get; set; }

        /// <summary>
        /// XMI name.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public virtual string Name { get; set; }

        /// <summary>
        /// XMI type.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Type { get; set; }
    }
}