namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Rich Text Format (RTF).
    /// </summary>
    public partial class RtfInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public RtfInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"\\pard\\sa200\\sl276\\slmult1\\b\\fs24 Appendix\\par {contents}\\par";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"\\b {name} \\b0";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"\\b {text} \\b0";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"\\i {citation} \\i0";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"\\f1\\fs20 {code.Replace("\n", "\\line ")} \\f0\\fs24\\par";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"\\b {enumuration}::{value} \\b0";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"\\i {text} \\i0";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"\\f1\\fs20 {code} \\f0\\fs24";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\\line ";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"\\i {expression} \\i0";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"\\par\\pard\\li720 1. {contents}\\par";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"\\b {name} \\b0";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"\\b {class_name}::{property_name} \\b0";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"\\par\\pard\\li720\\i {contents} \\i0\\par";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"\\par\\pard\\sa200\\sl276\\slmult1\\b\\fs24 {contents}\\par\\b0";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"\\par\\pard\\sa200\\sl276\\slmult1\\b\\fs28 {title}\\par\\b0";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var rtfTable = string.Join("\\par ", rows);
            return rtfTable;
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"\\i {term} \\i0";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"\\i {term}s \\i0";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"\\par\\pard\\li720\\bullet {contents}\\par";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"\\ul {address} \\ulnone";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in an RTF comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>An RTF comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"{{\\*\\comment UNHANDLED MARKDOWN: {contents}}}";
    }
}
