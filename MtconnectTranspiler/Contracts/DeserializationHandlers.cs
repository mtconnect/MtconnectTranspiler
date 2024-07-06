using Microsoft.Extensions.Logging;
using System.Xml.Serialization;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Event handlers for XML deserialization.
    /// </summary>
    public class DeserializationHandlers
    {
        private ILogger<XmiDeserializer>? _logger;

        /// <summary>
        /// Constructs a new instance of the container of event handlers.
        /// </summary>
        /// <param name="logger"></param>
        public DeserializationHandlers(ILogger<XmiDeserializer>? logger = null)
        {
            _logger = logger;
        }

        /// <inheritdoc cref="XmlDeserializationEvents.OnUnknownAttribute"/>
        public void OnUnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            _logger?.LogWarning("Unknown Attribute: {AttributeName} = {AttributeValue}; Parent Element = ", e.Attr.Name, e.Attr.Value, e.Attr.OwnerElement?.Name);
            //Console.WriteLine($"Unknown Attribute: {e.Attr.Name} = {e.Attr.Value}");
        }

        /// <inheritdoc cref="XmlDeserializationEvents.OnUnknownElement"/>
        public void OnUnknownElement(object sender, XmlElementEventArgs e)
        {
            _logger?.LogWarning("Unknown Element: {ElementName} (Parent: {ParentName})", e.Element.Name, e.Element.ParentNode?.Name);
            //Console.WriteLine($"Unknown Element: {e.Element.Name}");
        }

        /// <inheritdoc cref="XmlDeserializationEvents.OnUnknownNode"/>
        public void OnUnknownNode(object sender, XmlNodeEventArgs e)
        {
            _logger?.LogWarning("Unknown Node: {NodeName} = {NodeType}", e.Name, e.NodeType);
            //Console.WriteLine($"Unknown Node: {e.Name} = {e.Text}");
        }

        /// <inheritdoc cref="XmlDeserializationEvents.OnUnreferencedObject"/>
        public void OnUnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            _logger?.LogWarning("Unreferenced Object: {Id} = {Object}", e.UnreferencedId, e.UnreferencedObject);
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
