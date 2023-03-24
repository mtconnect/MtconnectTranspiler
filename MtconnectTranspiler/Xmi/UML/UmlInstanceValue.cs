using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;defaultValue xmi:type='uml:InstanceValue' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
    public class UmlInstanceValue : DefaultValue
    {
        public override string Type => "uml:InstanceValue";

        /// <summary>
        /// Represents the <c>instance</c> attribute in a <c>&lt;defaultValue xmi:type='uml:InstanceValue' /&gt;</c> element.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.instance, Namespace = "")]
        internal string _instance { get; set; }
        /// <inheritdoc cref="_association"/>
        public string Instance => _instance;
    }
}