using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" />.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="XmiElement" />.</typeparam>
    public interface IModel<T> where T : XmiElement
    {
        string Href { get; }

        string SysML_ID { get; }

        string SysML_Name { get; }

        /// <summary>
        /// Reference to the source <see cref="XmiElement" />.
        /// </summary>
        T Source { get; }
    }
}
