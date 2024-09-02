namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to HTML.
    /// </summary>
    public partial class HtmlInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public HtmlInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"<section class=\"appendix\">{contents}</section>";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"<div id=\"{name}\">{name}</div>";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"<strong>{text}</strong>";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"<cite>{citation}</cite>";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"<pre><code class=\"{language}\">{code}</code></pre>";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"<dfn>{enumuration}.{value}</dfn>";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"<em>{text}</em>";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"<code>{code}</code>";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "<br/>";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"<span class=\"math\">{expression}</span>";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"<abbr title=\"{definition}\">{contents} ({acronym1})</abbr>";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"<ol><li>{contents}</li></ol>";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"<span class=\"package\">{name}</span>";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"<code>{class_name}.{property_name}</code>";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"<blockquote>{contents}</blockquote>";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"<section>{contents}</section>";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"<h2>{title}</h2>";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
            => $"<table>{contents.Replace("|", "").Trim()}</table>";

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"<span class=\"term\">{term}</span>";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"<span class=\"term\">{term}s</span>";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"<ul><li>{contents}</li></ul>";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"<a href=\"{address}\">{address}</a>";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a comment for HTML.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>An HTML comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {contents} -->";
    }
}
