using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:Restriction /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ConceptModelingProfileStructure.RESTRICTION, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
    public class Restriction : ProfileElement
    {
        /// <summary>
        /// <c>base_Property</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseProperty, Namespace = "")]
        public string? BaseProperty { get; set; }
    }
}