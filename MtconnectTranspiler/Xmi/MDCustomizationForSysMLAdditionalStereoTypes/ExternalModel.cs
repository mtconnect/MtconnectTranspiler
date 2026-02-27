using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes
{
    /// <summary>
    /// <c>&lt;MD_Customization_for_SysML__additional_stereotypes:ExternalModel /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.EXTERNAL_MODEL, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
    public class ExternalModel : ProfileElement
    {
        /// <summary>
        /// <c>base_Element</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.baseElement, Namespace = "")]
        public string? BaseElement { get; set; }
    }
}
