namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Generic reference to a <c>xmi</c> element
    /// </summary>
    public interface IXmiElement
    {
        /// <summary>
        /// Represents the <c>xmi:id</c> attribute on the element
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Represents the <c>name</c> attribute on the element
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Represents the <c>xmi:type</c> attribute on the element
        /// </summary>
        string Type { get; set; }
    }
}