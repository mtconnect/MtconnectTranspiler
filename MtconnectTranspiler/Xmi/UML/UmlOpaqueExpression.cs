using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;specification xmi:type='uml:OpaqueExpression' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.SPECIFICATION, Namespace = "")]
    public class UmlOpaqueExpression : Specification
    {
        public override string Type => "uml:OpaqueExpression";
    }
}