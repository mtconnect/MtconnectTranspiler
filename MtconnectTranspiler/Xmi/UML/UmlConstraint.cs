using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.OwnedRule"/> where <c>xmi:type='uml:Constraint'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_RULE, Namespace = "")]
    public class UmlConstraint : OwnedRule
    {
        /// <summary>
        /// Child <inheritdoc cref="MtconnectTranspiler.Xmi.ConstrainedElement"/>
        /// </summary>
        [XmlElement(ElementName = XmlHelper.XmiStructure.CONSTRAINED_ELEMENT, Namespace = "")]
        public ConstrainedElement? ConstrainedElement { get; set; }
    }
}