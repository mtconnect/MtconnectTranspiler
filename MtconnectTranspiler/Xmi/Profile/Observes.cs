using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:observes /&gt;</c>
    /// </summary>
    public class Observes : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseAssociation, Namespace = "")]
        public string BaseAssociation { get; set; }
    }
}