using MtconnectTranspiler.Contracts;
using System;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Xmi.UML
{
    /// <summary>
    /// <inheritdoc cref="MtconnectTranspiler.Xmi.PackageImport"/> where <c>xmi:type='uml:PackageImport'</c>
    /// </summary>
    [Serializable, XmlRoot(ElementName = XmlHelper.XmiStructure.PACKAGE_IMPORT, Namespace = "")]
    public class UmlPackageImport : PackageImport
    {
        /// <inheritdoc cref="MtconnectTranspiler.Xmi.XmiElement.Type"/>
        public override string Type => XmlHelper.UmlStructure.PackageImport;

        /// <summary>
        /// <c>importedPackage</c> attribute
        /// </summary>
        [XmlAttribute(AttributeName = XmlHelper.XmiStructure.importedPackage, Namespace = "")]
        public string? ImportedPackage { get; set; }
    }
}