using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" />.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="XmiElement" />.</typeparam>
    public interface IModel<T> where T : XmiElement
    {
        /// <summary>
        /// Represents a hyperlink reference to the documentation hosted on <see href="https://model.mtconnect.org/">model.mtconnect.org</see>
        /// </summary>
        string Href { get; }

        /// <summary>
        /// Represents the internal ID within the XMI model.
        /// </summary>
        string SysML_ID { get; }

        /// <summary>
        /// Represents the name of the source XMI element.
        /// </summary>
        string SysML_Name { get; }

        /// <summary>
        /// Reference to the source <see cref="XmiElement" />.
        /// </summary>
        T Source { get; }
    }
}
