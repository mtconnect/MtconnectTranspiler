using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Navigation;
using MtconnectTranspiler.Xmi.Profile;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:x /&gt;</c> element
    /// </summary>
    public abstract class ProfileElement
    {
        private string _id;
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
                IdCacheContextHolder.Current?.AddToCache(_id, this);
            }
        }
    }
}
