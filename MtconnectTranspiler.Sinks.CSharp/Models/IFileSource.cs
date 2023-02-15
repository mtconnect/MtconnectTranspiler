namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Represents an object that is intended to directly convert into a file.
    /// </summary>
    public interface IFileSource
    {
        /// <summary>
        /// Reference to the expected name for the coverted file.
        /// </summary>
        string Filename { get; set;  }

        /// <summary>
        /// Reference to the expected namespace for the converted file contents.
        /// </summary>
        string Namespace { get; set; }
    }
}
