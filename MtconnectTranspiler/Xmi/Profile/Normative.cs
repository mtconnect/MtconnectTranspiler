﻿using MtconnectTranspiler.Contracts;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.Profile
{
    /// <summary>
    /// Represents <c>&lt;MTConnectProfile:normative /&gt;</c>
    /// </summary>
    public class Normative : ProfileElement
    {
        /// <summary>
        /// Foreign key to the <see cref="XmiElement.Id"/> of the object this applies to.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.baseElement, Namespace = "")]
        public string BaseElement { get; set; }

        /// <summary>
        /// The version for which the object was deprecated in MTConnect.
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.version, Namespace = "")]
        public string Version { get; set; }
    }
}