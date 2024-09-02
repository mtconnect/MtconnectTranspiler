using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:Disjoint_With /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ConceptModelingProfileStructure.DISJOINT_WITH, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
    public class DisjointWith : ProfileElement
    {
        /// <summary>
        /// <c>base_Dependency</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseDependency, Namespace = "")]
        public string? BaseDependency { get; set; }
    }
}