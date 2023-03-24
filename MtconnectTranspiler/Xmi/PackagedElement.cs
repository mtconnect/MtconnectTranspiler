using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;packagedElement /&gt;</c> element
    /// </summary>
    [Serializable, XmlType(Namespace = XmlHelper.UmlNamespace), XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGED_ELEMENT, Namespace = XmlHelper.UmlNamespace)]
    [XmlInclude(typeof(UmlPackage)),
        XmlInclude(typeof(UmlProfile)),
        XmlInclude(typeof(UmlClass)),
        XmlInclude(typeof(UmlEnumeration)),
        XmlInclude(typeof(UmlExtension)),
        XmlInclude(typeof(UmlPrimitiveType)),
        XmlInclude(typeof(UmlStereotype))]
    public class PackagedElement : XmiElement
    {
    }
}