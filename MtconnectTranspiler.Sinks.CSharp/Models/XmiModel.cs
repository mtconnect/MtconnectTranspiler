using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public abstract class XmiModel<T> : IModel<T> where T : XmiElement
    {
        public string Href => $"{Constants.SysMLWebReport}/index.html#{Source.Type}_{SysML_ID}";

        public string SysML_ID { get; }

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
