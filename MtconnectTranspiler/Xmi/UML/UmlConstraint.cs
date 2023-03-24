using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;ownedRule xmi:type='uml:Constraint' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_RULE, Namespace = "")]
    public class UmlConstraint : OwnedRule
    {
        [XmlElement(ElementName = XmlHelper.XmiStructure.CONSTRAINED_ELEMENT, Namespace = "")]
        public ConstrainedElement? ConstrainedElement { get; set; }
    }
}