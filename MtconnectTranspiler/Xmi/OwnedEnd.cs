﻿using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// The abstract for a <c>&lt;ownedEnd /&gt;</c>.
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_END, Namespace = "")]
    public class OwnedEnd : XmiElement
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.visibility, Namespace = "")]
        public string Visibility { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.aggregation, Namespace = "")]
        public string Aggregation { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.type, Namespace = "")]
        public string TypeId { get; set; }

        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.association, Namespace = "")]
        public string Association { get; set; }

        // TODO: Add lowerValue
        // TODO: Add xmi:Extension;
        // TODO: Handle variants of attributes as elements. For example, if type is not an attribute it could be an element.
    }
}