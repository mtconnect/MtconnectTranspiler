using System.Linq;
using System.Text;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to YAML format.
    /// </summary>
    public partial class YamlInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public YamlInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"# Appendix\n{contents}";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"{name}";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"**{text}**"; // YAML doesn't support rich text, so fallback to markdown

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"# See: {citation}";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"```{language}\n{code}\n```"; // Preserving code blocks in markdown

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"{enumuration}::{value}";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"*{text}*"; // YAML doesn't support rich text, so fallback to markdown

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"`{code}`"; // Preserving inline code in markdown

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\n";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"{expression}"; // Plain text for math expressions

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"- {contents}"; // YAML uses '-' for lists

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"{name}";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"{class_name}.{property_name}";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"> {contents}"; // Quoting in YAML is similar to markdown

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"# {contents}";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"# {title}";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            // Convert markdown table to YAML-friendly format
            var rows = contents.Trim().Split('\n');
            var header = rows[0].Split('|');
            var separator = rows[1].Split('|');
            var tableRows = rows.Skip(2);

            var yamlTable = new StringBuilder();
            yamlTable.AppendLine(header.Select(h => h.Trim()).Aggregate((a, b) => $"{a}: {b}"));
            foreach (var row in tableRows)
            {
                var columns = row.Split('|');
                for (int i = 0; i < columns.Length; i++)
                {
                    yamlTable.AppendLine($"  - {header[i].Trim()}: {columns[i].Trim()}");
                }
            }

            return yamlTable.ToString();
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"{term}";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"{term}s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"- {contents}"; // YAML uses '-' for unordered lists

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => address; // No special formatting needed for URLs

        /// <summary>
        /// Handles any unhandled markdown by commenting it out in YAML.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A YAML comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"# UNHANDLED MARKDOWN: {contents}";
    }
}
