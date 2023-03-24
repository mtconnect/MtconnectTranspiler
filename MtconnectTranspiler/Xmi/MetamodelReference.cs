using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// Represents <c>&lt;metamodelReference /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.METAMODEL_REFERENCE, Namespace = "")]
    public class MetamodelReference : XmiElement
    {
        /// <summary>
        /// Represents <c>xmi:idref</c> in <c>&lt;metamodelReference /&gt;</c>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.idRef, Namespace = XmlHelper.XmiNamespace)]
        public string? IdRef { get; set; }
    }
}