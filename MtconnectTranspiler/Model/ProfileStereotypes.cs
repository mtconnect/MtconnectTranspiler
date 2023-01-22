using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Model
{
    /// <summary>
    /// Represents <c>&lt;packageElement xmi:type='uml:Package' name='Stereotypes' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = "")]
    public class ProfileStereotypes : UmlPackage
    {

    }
}