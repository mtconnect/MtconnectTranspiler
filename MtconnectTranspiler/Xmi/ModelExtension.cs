using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents a <c>&lt;xmi:Extension /&gt;</c> element.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MODEL_EXTENSION, Namespace = "")]
    public class ModelExtension
    {
        /// <summary>
        /// Represents the <c>&lt;upperValue /&gt;</c> element.
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.UPPER_VALUE, Namespace = "")]
        public UpperValue? UpperValue { get; set; }

        /// <summary>
        /// Represents the <c>&lt;lowerValue /&gt;</c> element.
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
        public UpperValue? LowerValue { get; set; }
    }
}