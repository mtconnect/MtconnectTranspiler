using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Model
{
    public abstract class ResponseDocument : PackagedElement
    {
        /// <summary>
        /// Description content in Cameo
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public OwnedComment[]? Comments { get; set; }

        /// <summary>
        /// Reference to the Response Document's root element
        /// </summary>
        public virtual UmlClass Root { get; set; }

        /// <summary>
        /// Reference to the Response Document's header element
        /// </summary>
        public virtual UmlClass Header { get; set; }
    }
}