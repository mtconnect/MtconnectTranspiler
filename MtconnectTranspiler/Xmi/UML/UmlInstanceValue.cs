﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.DefaultValue"/> where <c>xmi:type='uml:InstanceValue'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.DEFAULT_VALUE, Namespace = "")]
    public class UmlInstanceValue : DefaultValue
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.InstanceValue;

        /// <summary>
        /// <c>instance</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.instance, Namespace = "")]
        public string? Instance { get; set; }
    }
}