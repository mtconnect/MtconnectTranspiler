using System.Linq;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to MediaWiki format.
    /// </summary>
    public partial class MediaWikiInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public MediaWikiInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"== Appendix ==\n{contents}\n";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"<code>{name}</code>";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"'''{text}'''";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"<ref>{citation}</ref>";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"<syntaxhighlight lang=\"{language}\">\n{code}\n</syntaxhighlight>";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"<code>{enumuration}::{value}</code>";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"''{text}''";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"<code>{code}</code>";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "<br />";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"<math>{expression}</math>";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"# {contents}";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"<code>{name}</code>";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"<code>{class_name}::{property_name}</code>";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"=== {contents} ===";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"== {title} ==";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var table = "{| class=\"wikitable\"\n";
            foreach (var row in rows)
            {
                var columns = row.Split('|').Select(col => $"| {col.Trim()}").ToArray();
                table += $"|-\n{string.Join("\n", columns)}\n";
            }
            table += "|}";
            return table;
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"''{term}''";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"''{term}s''";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"* {contents}";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"[http://{address} {address}]";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a MediaWiki comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A MediaWiki comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {contents} -->";
    }
}
