using MtconnectTranspiler.Xmi;
using System;

namespace MtconnectTranspiler.Sinks.Models
{
    /// <summary>
    /// Abstract representation of a XMI model item.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class XmiModel<T> : IModel<T> where T : XmiElement
    {
        /// <inheritdoc />
        public string Href => $"https://model.mtconnect.org/index.html#{Source.Type}_{SysML_ID}";

        /// <inheritdoc />
        public string SysML_ID { get; }

        /// <inheritdoc />
        public string SysML_Name { get; }

        /// <inheritdoc />
        public T Source { get; }

        /// <summary>
        /// Constructs a new XMI model item.
        /// </summary>
        /// <param name="source"></param>
        public XmiModel(T source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (string.IsNullOrEmpty(source.Id))
                throw new ArgumentNullException(nameof(source.Id));
            if (string.IsNullOrEmpty(source.Name))
                throw new ArgumentNullException(nameof(source.Name));

            SysML_ID = source.Id!;
            SysML_Name = source.Name!;

            Source = source;
        }
    }
}
