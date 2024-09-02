using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.ConceptModelingProfile
{
    /// <summary>
    /// <c>&lt;Concept_Modeling_Profile:Literal_Annotation /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.ConceptModelingProfileStructure.LITERAL_ANNOTATION, Namespace = XmlHelper.Concept_Modeling_ProfileNamespace)]
    public class LiteralAnnotation : ProfileElement
    {
        /// <summary>
        /// <c>base_Comment</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.ConceptModelingProfileStructure.baseComment, Namespace = "")]
        public string? BaseComment { get; set; }
    }
}