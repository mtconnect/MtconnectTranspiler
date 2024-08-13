using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to OpenDocument Text (ODT) format.
    /// </summary>
    public partial class OpenDocumentTextInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public OpenDocumentTextInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"<text:h text:style-name=\"Heading_20_1\">Appendix</text:h>\n<text:p>{contents}</text:p>";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"<text:code>{name}</text:code>";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"<text:span text:style-name=\"Bold\">{text}</text:span>";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"<text:note><text:note-citation>{citation}</text:note-citation><text:note-body><text:p>{citation}</text:p></text:note-body></text:note>";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"<text:preformatted text:style-name=\"Preformatted_20_Text\">{EscapeXml(code)}</text:preformatted>";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"<text:span text:style-name=\"Code\">{enumuration}::{value}</text:span>";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"<text:span text:style-name=\"Italic\">{text}</text:span>";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"<text:span text:style-name=\"Code\">{EscapeXml(code)}</text:span>";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "<text:line-break/>";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"<text:span text:style-name=\"Math\">{EscapeXml(expression)}</text:span>";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"<text:span text:style-name=\"Acronym\">{contents} ({acronym1}: {definition})</text:span>";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"<text:list text:style-name=\"Numbering_20_1\"><text:list-item><text:p>{contents}</text:p></text:list-item></text:list>";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"<text:span text:style-name=\"Code\">{name}</text:span>";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"<text:span text:style-name=\"Code\">{class_name}::{property_name}</text:span>";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"<text:span text:style-name=\"Quotation\">{contents}</text:span>";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"<text:h text:style-name=\"Heading_20_2\">{contents}</text:h>";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"<text:h text:style-name=\"Heading_20_1\">{title}</text:h>";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var table = "<table:table table:name=\"Table\" table:style-name=\"Table_20_Style_20_1\">\n";
            foreach (var row in rows)
            {
                table += "<table:table-row>\n";
                var columns = row.Split('|').Select(col => $"<table:table-cell><text:p>{EscapeXml(col.Trim())}</text:p></table:table-cell>").ToArray();
                table += string.Join("\n", columns) + "\n";
                table += "</table:table-row>\n";
            }
            table += "</table:table>";
            return table;
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"<text:span text:style-name=\"Term\">{term}</text:span>";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"<text:span text:style-name=\"Term\">{term}s</text:span>";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"<text:list text:style-name=\"Bullet_20_Symbol\"><text:list-item><text:p>{contents}</text:p></text:list-item></text:list>";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"<text:a xlink:href=\"http://{EscapeXml(address)}\">{address}</text:a>";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in an OpenDocument Text comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>An ODT comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {EscapeXml(contents)} -->";

        /// <summary>
        /// Escapes special XML characters to ensure valid ODT output.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The escaped string.</returns>
        private string EscapeXml(string input)
        {
            return input.Replace("&", "&amp;")
                        .Replace("<", "&lt;")
                        .Replace(">", "&gt;")
                        .Replace("\"", "&quot;")
                        .Replace("'", "&apos;");
        }
    }
}
