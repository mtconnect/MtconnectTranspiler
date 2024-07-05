using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Abstract model for common <c>xmi</c> elements
    /// </summary>
    public abstract class XmiElement : IXmiElement
    {
        /// <summary>
        /// <c>xmi:id</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? Id { get; set; }

        /// <summary>
        /// <c>name</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public virtual string? Name { get; set; }

        /// <summary>
        /// <c>xmi:type</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? Type { get; set; }

        public virtual XmiElement? FindById(string id)
        {
            if (Id == id)
                return this;
            return null;
        }
    }
}