using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MagicDrawProfile
{
    /// <summary>
    /// <c>&lt;MagicDraw_Profile:additionalElementImport /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MagicDrawProfileStructure.ADDITIONAL_ELEMENT_IMPORT, Namespace = XmlHelper.MagicDraw_ProfileNamespace)]
    public class AdditionalElementImport : ProfileElement
    {
        /// <summary>
        /// <c>base_ElementImport</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.baseElementImport, Namespace = "")]
        public string? BaseElementImport { get; set; }

        /// <summary>
        /// <c>treatAsAuxiliaryInOwningProject</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.MagicDrawProfileStructure.treatAsAuxiliaryInOwningProject, Namespace = "")]
        public string? TreatAsAuxiliaryInOwningProject { get; set; }
    }
}
