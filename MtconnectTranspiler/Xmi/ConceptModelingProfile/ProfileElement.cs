using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Navigation;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:x /&gt;</c> element
    /// </summary>
    public abstract class ProfileElement
    {
        private string? _id;
        /// <summary>
        /// <c>xmi:id</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                if (!string.IsNullOrEmpty(_id))
                    IdCacheContextHolder.Current?.AddToCache(_id!, this);
            }
        }
    }
}