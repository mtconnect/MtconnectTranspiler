namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to plain text format.
    /// </summary>
    public partial class PlainTextInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public PlainTextInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"Appendix: {contents}";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => name;

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => text; // No formatting, just plain text

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"See: {citation}";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => code;

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"{enumuration}::{value}";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => text; // No formatting, just plain text

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => code; // No formatting, just plain text

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\n";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => expression; // No special formatting for math in plain text

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"1. {contents}";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => name;

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"{class_name}::{property_name}";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"Section: {contents}";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"\n{title}\n" + new string('-', title.Length);

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var plainTextTable = string.Join("\n", rows);
            return plainTextTable;
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => term;

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"{term}s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"* {contents}";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => address;

        /// <summary>
        /// Handles any unhandled markdown by simply returning the content as-is.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>The plain text content.</returns>
        public string UnhandledInterpreter(string contents)
            => contents;
    }
}
