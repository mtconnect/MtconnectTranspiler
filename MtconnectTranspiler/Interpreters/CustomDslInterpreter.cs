namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to a custom DSL format.
    /// </summary>
    public partial class CustomDslInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public CustomDslInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"Appendix: {contents}";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"Block: {name}";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"**{text}**"; // Retaining markdown-style bold for the DSL

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"Cite: {citation}";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"Code({language}):\n{code}";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"{enumuration}::{value}";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"*{text}*"; // Retaining markdown-style emphasis for the DSL

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"`{code}`"; // Retaining markdown-style inline code for the DSL

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\n";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"Math: {expression}";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"1. {contents}"; // Simple numbered list format for the DSL

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"Package: {name}";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"{class_name}.{property_name}";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"Section: {contents}";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"Section: {title}";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
            => $"Table: {contents.Replace("|", " ").Trim()}"; // Convert table row to simple space-separated content

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"Term: {term}";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"Terms: {term}s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"- {contents}"; // Simple bullet list format for the DSL

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"URL: {address}";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a comment for the DSL.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A comment in the DSL indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"// UNHANDLED: {contents}";
    }
}
