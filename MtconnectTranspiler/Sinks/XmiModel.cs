using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
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

        public XmiModel(T source)
        {
            SysML_ID = source.Id;
            SysML_Name = source.Name;

            Source = source;
        }
    }
}
