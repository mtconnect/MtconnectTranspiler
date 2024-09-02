using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Navigation;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Abstract model for common <c>xmi</c> elements
    /// </summary>
    public abstract class XmiElement : IXmiElement
    {
        private string? _id;
        /// <summary>
        /// <c>xmi:id</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? Id
        {
            get { return _id; }
            set {
                _id = value;
                if (!string.IsNullOrEmpty(_id))
                    IdCacheContextHolder.Current?.AddToCache(_id!, this);
            }
        }

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
    }
}