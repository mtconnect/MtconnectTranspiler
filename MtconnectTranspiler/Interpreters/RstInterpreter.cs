namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to reStructuredText (RST) format.
    /// </summary>
    public partial class RSTInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public RSTInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"{contents}\n\n.. _appendix:\n";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"``{name}``";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"**{text}**";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"[CITATION: {citation}]_";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $".. code-block:: {language}\n\n    {code.Replace("\n", "\n    ")}";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"``{enumuration}::{value}``";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"*{text}*";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"``{code}``";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\n\n";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $".. math::\n\n    {expression}";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"#. {contents}";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"``{name}``";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"``{class_name}::{property_name}``";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"\n.. _sect_{contents}:\n\n{contents}\n" + new string('-', contents.Length);

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"{title}\n" + new string('=', title.Length);

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var table = string.Join("\n", rows);
            var separator = new string('=', rows[0].Length);

            return $"{separator}\n{table}\n{separator}";
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"*{term}*";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"*{term}*s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"* {contents}";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"`{address} <{address}>`_";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a reStructuredText comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>An RST comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $".. UNHANDLED MARKDOWN: {contents}";
    }
}
