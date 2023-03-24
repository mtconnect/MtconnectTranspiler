using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// <c>&lt;Profile:organizer /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ProfileStructure.ORGANIZER, Namespace = XmlHelper.ProfileNamespace)]
    public class Organizer : ProfileElement
    {
        /// <summary>
        /// <c>base_Element</c> attribute.
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseElement, Namespace = "")]
        public string? BaseElement { get; set; }
    }
}