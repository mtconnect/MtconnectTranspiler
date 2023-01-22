using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.OWNED_END, Namespace = "")]
    public class UmlExtensionEnd : OwnedEnd
    {

    }
}