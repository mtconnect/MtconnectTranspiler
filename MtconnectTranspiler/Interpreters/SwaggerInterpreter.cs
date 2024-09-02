using System.Linq;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Swagger/OpenAPI documentation format.
    /// </summary>
    public partial class SwaggerInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public SwaggerInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => UnhandledInterpreter(contents); // Swagger doesn't have an equivalent concept for appendix

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"`{name}`"; // Code blocks in Swagger documentation

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"**{text}**"; // Markdown-style bold in Swagger

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"[See {citation}](#{citation.ToLower().Replace(' ', '-')})"; // Swagger uses Markdown-style links

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"```{language}\n{code}\n```"; // Markdown-style code blocks

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"`{enumuration}::{value}`"; // Code-style formatting for definitions

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"*{text}*"; // Markdown-style emphasis

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"`{code}`"; // Inline code in Markdown

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "  \n"; // Markdown-style line break

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"`{expression}`"; // No native math support, use code formatting

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})"; // Plain text for acronyms

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"1. {contents}"; // Ordered list format in Markdown

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"`{name}`"; // Code-style formatting for package names

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"`{class_name}.{property_name}`"; // Code-style formatting for properties

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}"; // Markdown-style blockquote

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"### {contents}"; // Subsection in Swagger documentation

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"## {title}"; // Section header in Swagger documentation

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var headerSeparator = string.Join(" | ", rows[0].Split('|').Select(_ => "---"));
            var table = string.Join("\n", rows);

            return $"{table}\n{headerSeparator}";
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"*{term}*"; // Italicize terms

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"*{term}s*"; // Italicize plural terms

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"* {contents}"; // Unordered list format in Markdown

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"[{address}]({address})"; // Markdown-style hyperlink

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {contents} -->";
    }
}
