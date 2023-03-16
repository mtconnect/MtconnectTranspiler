using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class UmlPackage : PackagedElement
    {
        /// <summary>
        /// Represents the <c>&lt;ownedComment xmi:type='uml:Comment' /&gt;</c> element(s).
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.OWNED_COMMENT)]
        public UmlComment[]? Comments { get; set; }

        /// <summary>
        /// Represents element(s):
        /// <list type="bullet">
        /// <item><c>&lt;packagedElement xmi:type='uml:Enumeration' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:DataType' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Class' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Stereotype' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Extension' /&gt;</c></item>
        /// <item><c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c></item>
        /// </list>
        /// </summary>
        [XPath("./packagedElement[@xmi:type='uml:Enumeration']", typeof(UmlEnumeration)),
            XPath("./packagedElement[@xmi:type='uml:DataType']", typeof(UmlDataType)),
            XPath("./packagedElement[@xmi:type='uml:Class']", typeof(UmlClass)),
            XPath("./packagedElement[@xmi:type='uml:Stereotype']", typeof(UmlStereotype)),
            XPath("./packagedElement[@xmi:type='uml:Extension']", typeof(UmlExtension)),
            XPath("./packagedElement[@xmi:type='uml:Package']", typeof(UmlPackage)),]
        public PackagedElement[]? Elements { get; set; }

        // TODO: Add xmi:Extension
    }
}