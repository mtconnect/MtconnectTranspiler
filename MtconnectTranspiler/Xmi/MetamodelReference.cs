using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;metamodelReference /&gt;</c> element
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.METAMODEL_REFERENCE, Namespace = "")]
    public class MetamodelReference : XmiElement
    {
        /// <summary>
        /// <c>xmi:idref</c> attribute
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}