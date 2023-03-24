using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;modelExtension /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.MODEL_EXTENSION, Namespace = "")]
    public class ModelExtension
    {
        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.UpperValue"/>
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.UPPER_VALUE, Namespace = "")]
        public UpperValue? UpperValue { get; set; }

        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.LowerValue"/>
        /// </summary>
        [XmlElement(XmlHelper.XmiStructure.LOWER_VALUE, Namespace = "")]
        public LowerValue? LowerValue { get; set; }
    }
}