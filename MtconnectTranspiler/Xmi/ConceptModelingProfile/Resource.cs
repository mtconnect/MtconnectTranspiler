using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:Resource /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ConceptModelingProfileStructure.RESOURCE, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
    public class Resource : ProfileElement
    {
        /// <summary>
        /// <c>base_Class</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseClass, Namespace = "")]
        public string? BaseClass { get; set; }

        /// <summary>
        /// <c>base_Class</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseProperty, Namespace = "")]
        public string? BaseProperty { get; set; }

        /// <summary>
        /// <c>IRI</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.IRI, Namespace = "")]
        public string? IRI { get; set; }
    }
}