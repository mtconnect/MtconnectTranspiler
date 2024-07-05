using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts.Navigation;
using MtconnectTranspiler.Xmi;
using System;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// A class that can deserialize a XMI document into an object-oriented form.
    /// </summary>
    public sealed class XmiDeserializer
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

        /// <summary>
        /// Deserializes the XML Document into the specified type.
        /// </summary>
        /// <returns>The deserialized object as a <see cref="XmiDocument"/>.</returns>
        public XmiDocument? Deserialize(CancellationToken cancellationToken)
        {
            XmiDocument? result = null;

            using(IdCacheContext cacheContext = new IdCacheContext())
            {
                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = xDoc.DocumentElement.LocalName;
                xRoot.IsNullable = true;
                xRoot.Namespace = XmlHelper.XmiNamespace;
                XmlSerializer serial = new XmlSerializer(typeof(Xmi.XmiDocument), xRoot);
                // Deserialize the XmlNode
                // QUESTION: Can I wrap this using with some sort of 'IdCacheContext' that entities like XmiElement can store their Id properties in?
                using (XmlNodeReader xReader = new XmlNodeReader(xDoc.DocumentElement))
                {
                    object? deserializedObject = serial.Deserialize(xReader, new DeserializationHandlers(_logger).ToDeserializationEvents());

                    result = deserializedObject as XmiDocument;
                    if (result != null)
                    {
                        result.SourceDocument = xDoc;
                        result.IdCache = cacheContext.IdCache;
                    }
                }
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
    public class DeserializationHandlers
    {
        private ILogger<XmiDeserializer>? _logger;

        public DeserializationHandlers(ILogger<XmiDeserializer>? logger = null)
        {
            _logger = logger;
        }

        public void OnUnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            _logger?.LogWarning("Unknown Attribute: {AttributeName} = {AttributeValue}; Parent Element = ", e.Attr.Name, e.Attr.Value, e.Attr.OwnerElement?.Name);
            //Console.WriteLine($"Unknown Attribute: {e.Attr.Name} = {e.Attr.Value}");
        }

        public void OnUnknownElement(object sender, XmlElementEventArgs e)
        {
            _logger?.LogWarning("Unknown Element: {ElementName} (Parent: {ParentName})", e.Element.Name, e.Element.ParentNode?.Name);
            //Console.WriteLine($"Unknown Element: {e.Element.Name}");
        }

        public void OnUnknownNode(object sender, XmlNodeEventArgs e)
        {
            _logger?.LogWarning("Unknown Node: {NodeName} = {NodeType}", e.Name, e.NodeType);
            //Console.WriteLine($"Unknown Node: {e.Name} = {e.Text}");
        }

        public void OnUnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            _logger?.LogWarning("Unreferenced Object: {Id} = {Object}", e.UnreferencedId, e.UnreferencedObject);
            //Console.WriteLine($"Unreferenced Object: {e.UnreferencedId} = {e.UnreferencedObject}");
        }

        public XmlDeserializationEvents ToDeserializationEvents()
            => new XmlDeserializationEvents()
            {
                OnUnknownAttribute = new XmlAttributeEventHandler(this.OnUnknownAttribute),
                OnUnknownElement = new XmlElementEventHandler(this.OnUnknownElement),
                OnUnknownNode = new XmlNodeEventHandler(this.OnUnknownNode),
                OnUnreferencedObject = new UnreferencedObjectEventHandler(this.OnUnreferencedObject),
            };
    }
}
