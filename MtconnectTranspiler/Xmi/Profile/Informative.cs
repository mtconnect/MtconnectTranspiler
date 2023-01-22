using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:informative /&gt;</c>
    /// </summary>
    public class Informative : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseElement, Namespace = "")]
        public string BaseElement { get; set; }
    }
}