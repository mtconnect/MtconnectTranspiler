using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <c>&lt;profileApplication /&gt;</c> where <c>xmi:type='uml:ProfileApplication'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PROFILE_APPLICATION, Namespace = "")]
    public class UmlProfileApplication : XmiElement
    {
        /// <inheritdoc cref="AppliedProfile"/>
        [XmlElement(ElementName = XmlHelper.XmiStructure.APPLIED_PROFILE, Namespace = "")]
        public AppliedProfile? AppliedProfile { get; set; }
    }
}