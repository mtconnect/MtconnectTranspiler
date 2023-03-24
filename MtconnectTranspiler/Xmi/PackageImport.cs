using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi
{
    /// <summary>
    /// <c>&lt;packageImport /&gt;</c> element
    /// </summary>
    [Serializable, XmlType(AnonymousType = true, Namespace = ""), XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
    public class PackageImport : XmiElement
    {
        // TODO: Add importedPackage
    }
}