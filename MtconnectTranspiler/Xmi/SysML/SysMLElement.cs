using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.SysML
{
    public abstract class SysMLElement
    {
        /// <summary>
        /// Unique ID within the XMI.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string Id { get; set; }

        // NOTE: Use this RegEx to filter/search the XMI <sysml\:(?!ValueType|Block|BindingConnector|NestedConnectorEnd|ConstraintBlock|ParticipantProperty|ElementGroup)
    }
}