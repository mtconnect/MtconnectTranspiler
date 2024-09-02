﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes
{
    /// <summary>
    /// <c>&lt;MD_Customization_for_SysML__additional_stereotypes:PartProperty /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.PART_PROPERTY, Namespace = XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace)]
    public class PartProperty : ProfileElement
    {
        /// <summary>
        /// <c>base_Property</c> attribute
        /// </summary>
        /// <remarks>Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.</remarks>
        [XmlAttribute(AttributeName = XmlHelper.MDCustomizationForSysMLAdditionalStereoTypes.baseProperty, Namespace = "")]
        public string? BaseProperty { get; set; }
    }
}
