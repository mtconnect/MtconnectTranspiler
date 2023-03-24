using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;Profile:organizer /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ProfileStructure.ORGANIZER, Namespace = XmlHelper.ProfileNamespace)]
    public class Organizer : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseElement, Namespace = "")]
        public string BaseElement { get; set; }
    }
}