using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes
{
    /// <summary>
    /// <c>&lt;MD_Customization_for_SysML__additional_stereotypes:ConstraintParameter /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.CONSTRAINT_PARAMETER, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
    public class ConstraintParameter : ProfileElement
    {
        /// <summary>
        /// <c>base_Port</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.basePort, Namespace = "")]
        public string? BasePort { get; set; }
    }
}
