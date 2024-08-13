namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Javadoc comments.
    /// </summary>
    public partial class JavadocInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public JavadocInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => UnhandledInterpreter(contents);

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => SeeInterpreter(name);

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"<b>{text}</b>";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => SeeInterpreter(citation);

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"<pre>{code}</pre>";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => SeeInterpreter($"{enumuration}.{value}");

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"<i>{text}</i>";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"<code>{code}</code>";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "<br/>";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => EmphasisInterpreter(expression); // Javadoc doesn't have native math support

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => EmphasisInterpreter($"{contents} ({acronym1}: {definition})");

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"<ol><li>{contents}</li></ol>";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => SeeInterpreter(name);

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => SeeInterpreter($"{class_name}.{property_name}");

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"<blockquote>{contents}</blockquote>";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => SeeInterpreter(contents);

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => UnhandledInterpreter(title);

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
            => $"<table>{contents.Replace("|", "").Trim()}</table>";

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => EmphasisInterpreter(term);

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => EmphasisInterpreter(term) + "s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"<ul><li>{contents}</li></ul>";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"<a href=\"{address}\">{address}</a>";

        /// <summary>
        /// Provides a `@see` reference for a Javadoc link.
        /// </summary>
        /// <param name="name">The name of the reference.</param>
        /// <returns>A formatted `@see` reference string.</returns>
        public string SeeInterpreter(string name)
            => $"@see {name}";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a Javadoc comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A Javadoc comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {contents} -->";
    }
}
