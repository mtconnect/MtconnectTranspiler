using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// Represents <c>&lt;packageImport xmi:type='uml:PackageImport' /&gt;</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
    public class UmlPackageImport : PackageImport
    {
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.importedPackage, Namespace = "")]
        public string ImportedPackage { get; set; }
    }
}