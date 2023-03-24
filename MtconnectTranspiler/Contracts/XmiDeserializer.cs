using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Xmi;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// A class that can deserialize a XMI document into an object-oriented form.
    /// </summary>
    public sealed class XmiDeserializer : XmlSerializer
    {
        private ILogger<XmiDeserializer>? _logger;
        private XmlDocument xDoc;
        private XmlNamespaceManager nsmgr;

        /// <summary>
        /// Constructs a new instance of the deserializer with a reference to the source document.
        /// </summary>
        /// <param name="xmlDocument">A source of XMI to deserialize</param>
        /// <param name="logger"><inheritdoc cref="ILogger" path="/summary"/></param>
        public XmiDeserializer(XmlDocument xmlDocument, ILogger<XmiDeserializer>? logger = null)
        {
            _logger = logger;

            xDoc = xmlDocument;
            nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            nsmgr.AddNamespace("xmi", XmlHelper.XmiNamespace);
            nsmgr.AddNamespace("uml", XmlHelper.UmlNamespace);
            nsmgr.AddNamespace("Profile", XmlHelper.ProfileNamespace);
            nsmgr.AddNamespace("StandardProfile", XmlHelper.StandardProfileNamespace);
            nsmgr.AddNamespace("Validation_Profile", XmlHelper.Validation_ProfileNamespace);
            nsmgr.AddNamespace("Dependency_Matrix_Profile", XmlHelper.Dependency_Matrix_ProfileNamespace);
            nsmgr.AddNamespace("Concept_Modeling_Profile", XmlHelper.Concept_Modeling_ProfileNamespace);
            nsmgr.AddNamespace("DSL_Customization", XmlHelper.DSL_CustomizationNamespace);
            nsmgr.AddNamespace("sysml", XmlHelper.SysMlNamespace);
            nsmgr.AddNamespace("MagicDraw_Profile", XmlHelper.MagicDraw_ProfileNamespace);
            nsmgr.AddNamespace("CCM_Internal_Implementation_Profile", XmlHelper.Ccm_Internal_Implementation_ProfileNamespace);
            nsmgr.AddNamespace("MD_Customization_for_SysML__additional_stereotypes", XmlHelper.Md_Customization_for_SysML__additional_stereotypesNamespace);
            nsmgr.AddNamespace("SimulationProfile", XmlHelper.SimulationProfileNamespace);
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            return base.Deserialize(reader);
        }

        /// <summary>
        /// Deserializes the XML Document into the specified type.
        /// </summary>
        /// <param name="predicatePath">Predicate XPath to start deserializing from.</param>
        /// <returns>The deserialized object as <typeparamref name="T"/>.</returns>
        public XmiDocument Deserialize(CancellationToken cancellationToken)
        {
            XmiDocument result = null;

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = xDoc.DocumentElement.LocalName;
            xRoot.IsNullable = true;
            xRoot.Namespace = XmlHelper.XmiNamespace;
            XmlSerializer serial = new XmlSerializer(typeof(Xmi.XmiDocument), xRoot);
            // Deserialize the XmlNode
            using (XmlNodeReader xReader = new XmlNodeReader(xDoc.DocumentElement))
            {
                object? deserializedObject = serial.Deserialize(xReader);

                result = deserializedObject as XmiDocument;

            }

            return result;
        }

        /// <summary>
        /// Creates a <see cref="XmiDeserializer"/> from a reference to the filepath of a XMI document.
        /// </summary>
        /// <param name="filename">Filepath to a XMI-formatted XML document.</param>
        /// <param name="logger"><inheritdoc cref="ILogger" path="/summary"/></param>
        /// <returns><inheritdoc cref="XmiDeserializer" path="/summary"/></returns>
        public static XmiDeserializer FromFile(string filename, ILogger<XmiDeserializer>? logger = null)
        {
            var xDoc = new XmlDocument();
            xDoc.Load(filename);

            return new XmiDeserializer(xDoc, logger);
        }

        /// <summary>
        /// Creates a <see cref="XmiDeserializer"/> from raw XML.
        /// </summary>
        /// <param name="xml">Raw XML string</param>
        /// <param name="logger"><inheritdoc cref="ILogger" path="/summary"/></param>
        /// <returns><inheritdoc cref="XmiDeserializer" path="/summary"/></returns>
        public static XmiDeserializer FromXml(string xml, ILogger<XmiDeserializer>? logger = null)
        {
            var xDoc = new XmlDocument();
            xDoc.LoadXml(xml);

            return new XmiDeserializer(xDoc, logger);
        }
    }
}
