using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:Equivalent_Class /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ConceptModelingProfileStructure.EQUIVALENT_CLASS, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
    public class EquivalentClass : ProfileElement
    {
        /// <summary>
        /// <c>base_Property</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseGeneralization, Namespace = "")]
        public string? BaseGeneralization { get; set; }
    }
}