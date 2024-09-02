using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.MagicDrawProfile;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.MDCustomizationForSysMLAdditionalStereoTypes
{
    /// <summary>
    /// <c>&lt;MD_Customization_for_SysML__additional_stereotypes:x /&gt;</c> element
    /// </summary>
    public abstract class ProfileElement
    {
        /// <summary>
        /// Unique ID within the XMI.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.id, Namespace = XmlHelper.XmiNamespace)]
        public virtual string? Id { get; set; }
    }
}
