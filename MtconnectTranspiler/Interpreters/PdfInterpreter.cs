using System.Linq;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to LaTeX format for PDF generation.
    /// </summary>
    public partial class PdfInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public PdfInterpreter() : base() { }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => $"\\appendix\n{contents}\n";

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => $"\\texttt{{{name}}}";

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"\\textbf{{{text}}}";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"\\cite{{{citation}}}";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"\\begin{{verbatim}}\n{EscapeLatex(code)}\n\\end{{verbatim}}";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => $"\\texttt{{{enumuration}::{value}}}";

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"\\textit{{{text}}}";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"\\texttt{{{EscapeLatex(code)}}}";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "\\newline\n";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => $"\\({EscapeLatex(expression)}\\)";

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string contents, string definition)
            => $"{contents} ({acronym1}: {definition})";

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"\\begin{{enumerate}}\n\\item {contents}\n\\end{{enumerate}}";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => $"\\texttt{{{name}}}";

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"\\texttt{{{class_name}::{property_name}}}";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"\\begin{{quote}}\n{contents}\n\\end{{quote}}";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => $"\\section*{{{contents}}}";

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => $"\\section{{{title}}}";

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
        {
            var rows = contents.Trim().Split('\n');
            var table = "\\begin{tabular}{|c|c|c|}\n\\hline\n";
            foreach (var row in rows)
            {
                var columns = row.Split('|').Select(col => EscapeLatex(col.Trim())).ToArray();
                table += $"{string.Join(" & ", columns)} \\\\ \\hline\n";
            }
            table += "\\end{tabular}\n";
            return table;
        }

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => $"\\textit{{{term}}}";

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => $"\\textit{{{term}}}s";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"\\begin{{itemize}}\n\\item {contents}\n\\end{{itemize}}";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"\\url{{{address}}}";

        /// <summary>
        /// Handles any unhandled markdown by wrapping it in a LaTeX comment.
        /// </summary>
        /// <param name="contents">The unhandled content.</param>
        /// <returns>A LaTeX comment indicating unhandled content.</returns>
        public string UnhandledInterpreter(string contents)
            => $"% UNHANDLED MARKDOWN: {EscapeLatex(contents)}";

        /// <summary>
        /// Escapes special LaTeX characters to ensure valid output.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The escaped string.</returns>
        private string EscapeLatex(string input)
        {
            return input.Replace("\\", "\\textbackslash{}")
                        .Replace("&", "\\&")
                        .Replace("%", "\\%")
                        .Replace("$", "\\$")
                        .Replace("#", "\\#")
                        .Replace("_", "\\_")
                        .Replace("{", "\\{")
                        .Replace("}", "\\}")
                        .Replace("~", "\\textasciitilde{}")
                        .Replace("^", "\\textasciicircum{}");
        }
    }
}
