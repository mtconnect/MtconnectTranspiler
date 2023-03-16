using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    public abstract class XmiElement : IXmiElement
    {
        /// <summary>
        /// Represents the <c>xmi:id</c> attribute in an element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Id { get; set; }

        /// <summary>
        /// Represents the <c>name</c> attribute in an element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.name, Namespace = "")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Represents the <c>xmi:type</c> attribute in an element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Type { get; set; }
    }
}