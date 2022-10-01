using MtconnectTranspiler.Contracts.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Contracts
{
    internal class XmiDeserializer
    {
        public string Filepath { get; private set; }

        private XmlDocument xDoc;
        private XmlNamespaceManager nsmgr;

        public XmiDeserializer(string filepath)
        {
            Filepath = filepath;

            xDoc = new XmlDocument();
            xDoc.Load(filepath);

            nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            nsmgr.AddNamespace("xmi", XmlHelper.XmiNamespace);
            nsmgr.AddNamespace("uml", XmlHelper.UmlNamespace);
        }

        /// <summary>
        /// Deserializes the XML Document into the specified type.
        /// </summary>
        /// <typeparam name="T">Generic type to deserialize the XML document into.</typeparam>
        /// <param name="predicatePath">Predicate XPath to start deserializing from.</param>
        /// <returns></returns>
        public T? Deserialize<T>(string predicatePath, CancellationToken cancellationToken) where T : class, new()
        {
            XmlNode? xPredicate = xDoc.SelectSingleNode(predicatePath, nsmgr);
            if (xPredicate == null) return null;

            var result = unwrapObject(xPredicate, typeof(T), cancellationToken);
            if (result == null) return null;

            return (T)result;
        }

        private object? unwrapObject(XmlNode xNode, Type targetType, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return null;

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


            System.Reflection.PropertyInfo[]? properties = targetType.GetProperties();

            Type attrXPath = typeof(XPathAttribute);
            foreach (var property in properties)
            {
                XPathAttribute? xpathAttribute = ((XPathAttribute[])property.GetCustomAttributes(attrXPath, true)).FirstOrDefault();
                if (xpathAttribute != null)
                {
                    if (property.PropertyType.IsArray)
                    {
                        XmlNodeList? xPropertyNodes = xNode.SelectNodes(xpathAttribute.Path, nsmgr);
                        if (xPropertyNodes != null)
                        {
                            Type? elementType = property.PropertyType.GetElementType();
                            List<object> collection = new List<object>();
                            foreach (XmlNode xChild in xPropertyNodes)
                            {
                                var childObject = unwrapObject(xChild, elementType, cancellationToken);
                                if (childObject != null)
                                {
                                    collection.Add(childObject);
                                }
                            }
                            Array typedArray = Array.CreateInstance(elementType, collection.Count);
                            Array.Copy(collection.ToArray(), typedArray, collection.Count);
                            property.SetValue(result, typedArray);
                        }
                    } else
                    {
                        XmlNode? xPropertyNode = xNode.SelectSingleNode(xpathAttribute.Path, nsmgr);
                        if (xPropertyNode != null)
                        {
                            property.SetValue(result, unwrapObject(xPropertyNode, property.PropertyType, cancellationToken));
                        }
                    }
                }
            }

            return result;
        }
    }
}
