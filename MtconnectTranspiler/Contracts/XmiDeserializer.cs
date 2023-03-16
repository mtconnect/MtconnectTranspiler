using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
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
        /// <typeparam name="T">Generic type to deserialize the XML document into.</typeparam>
        /// <param name="predicatePath">Predicate XPath to start deserializing from.</param>
        /// <returns>The deserialized object as <typeparamref name="T"/>.</returns>
        public T? Deserialize<T>(string predicatePath, CancellationToken cancellationToken) where T : class, new()
        {
            XmlNode? xPredicate = xDoc.SelectSingleNode(predicatePath, nsmgr);
            if (xPredicate == null)
            {
                _logger?.LogError("Could not find XmlNode from predicatePath '{predicatePath}'", predicatePath);
                return null;
            }

            var result = unwrapObject(xPredicate, typeof(T), cancellationToken);
            if (result == null)
            {
                _logger?.LogError("Unable to deserialize type starting from predicatePath '{predicatePath}'", predicatePath);
                return null;
            }

            return (T)result;
        }

        private object? unwrapObject(XmlNode xNode, Type targetType, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                _logger?.LogInformation("Deserialization aborting due to cancellation");
                return null;
            }

            object? result = null;

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = xNode.LocalName;
            xRoot.IsNullable = true;
            xRoot.Namespace = xNode.NamespaceURI;
            XmlSerializer serial = new XmlSerializer(targetType, xRoot);
            // Deserialize the XmlNode
            using (XmlNodeReader xReader = new XmlNodeReader(xNode))
            {
                object? deserializedObject = serial.Deserialize(xReader);
                if (deserializedObject != null)
                {
                    result = deserializedObject;
                }
            }


            System.Reflection.PropertyInfo[]? properties = targetType
                .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach (var property in properties)
            {
                ParseXPathAttribute(xNode, targetType, result, property, cancellationToken);
                ParseXmlAttributeAttribute(xNode, targetType, result, property, cancellationToken);
            }

            return result;
        }

        private Type XPathAttributeType = typeof(XPathAttribute);
        private void ParseXPathAttribute(XmlNode xNode, Type targetType, object? result, PropertyInfo property, CancellationToken cancellationToken)
        {
            XPathAttribute[] xpathAttributes = ((XPathAttribute[])property.GetCustomAttributes(XPathAttributeType, true));
            foreach (var xpathAttribute in xpathAttributes)
            {
                if (property.PropertyType.IsArray)
                {
                    _logger?.LogTrace("Deserializing array property '{PropertyName}' in '{TargetType}'", property.Name, targetType.FullName);
                    XmlNodeList? xPropertyNodes = xNode.SelectNodes(xpathAttribute.Path, nsmgr);
                    if (xPropertyNodes != null)
                    {
                        Type? elementType = property.PropertyType.GetElementType();
                        Type? resultType = xpathAttribute.Type ?? elementType;
                        List<object> collection = new List<object>();
                        foreach (XmlNode xChild in xPropertyNodes)
                        {
                            var childObject = unwrapObject(xChild, resultType, cancellationToken);
                            if (childObject != null)
                            {
                                collection.Add(childObject);
                            }
                        }
                        object[]? existingArray = property.GetValue(result) as object[];
                        if (existingArray?.Length > 0)
                        {
                            collection.InsertRange(0, existingArray);
                        }
                        Array typedArray = Array.CreateInstance(elementType, collection.Count);
                        Array.Copy(collection.ToArray(), typedArray, collection.Count);
                        property.SetValue(result, typedArray);
                    }
                }
                else
                {
                    _logger?.LogTrace("Deserializing property '{PropertyName}' in '{TargetType}'", property.Name, targetType.FullName);
                    XmlNode? xPropertyNode = xNode.SelectSingleNode(xpathAttribute.Path, nsmgr);
                    if (xPropertyNode != null)
                    {
                        property.SetValue(result, unwrapObject(xPropertyNode, xpathAttribute.Type ?? property.PropertyType, cancellationToken));
                    }
                }
            }
        }

        private Type XmlAttributeType = typeof(XmlAttributeAttribute);
        private void ParseXmlAttributeAttribute(XmlNode xNode, Type targetType, object? result, PropertyInfo property, CancellationToken cancellationToken)
        {
            XmlAttributeAttribute[] xAttributes = ((XmlAttributeAttribute[])property.GetCustomAttributes(XmlAttributeType, true));
            foreach (var xAttribute in xAttributes)
            {
                _logger?.LogTrace("Deserializing property '{PropertyName}' in '{TargetType}'", property.Name, targetType.FullName);
                XmlAttribute? xProperty = xNode.Attributes[xAttribute.AttributeName, xAttribute.Namespace];

                if (xProperty != null)
                {
                    property.SetValue(result, xProperty.Value);
                }
            }
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
