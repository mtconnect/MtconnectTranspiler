using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// <c>&lt;Profile:observes /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ProfileStructure.OBSERVES, Namespace = XmlHelper.ProfileNamespace)]
    public class Observes : ProfileElement
    {
        /// <summary>
        /// <c>base_Association</c> attribute.
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseAssociation, Namespace = "")]
        public string? BaseAssociation { get; set; }
    }
}