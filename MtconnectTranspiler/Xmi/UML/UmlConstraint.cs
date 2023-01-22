using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Contracts.Attributes;
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
        [XPath("./constrainedElement@xmi:idref")]
        public string ConstrainedElement { get; set; }
    }
}