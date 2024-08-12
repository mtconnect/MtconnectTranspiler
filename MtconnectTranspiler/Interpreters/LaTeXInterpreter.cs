namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to LaTeX commands.
    /// </summary>
    public partial class LaTeXInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public LaTeXInterpreter() : base()
        {
            // Bold text: **text** -> \textbf{text}
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> \textit{text}
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Header 1: # Header -> \section{Header}
            AddInterpreter(@"(?<block>^\# (?<contents>.*?)$)", SectionInterpreter);

            // Header 2: ## Header -> \subsection{Header}
            AddInterpreter(@"(?<block>^\#\# (?<contents>.*?)$)", SubsectionInterpreter);

            // Header 3: ### Header -> \subsubsection{Header}
            AddInterpreter(@"(?<block>^\#\#\# (?<contents>.*?)$)", SubsubsectionInterpreter);

            // Inline math: $math$ -> \(math\)
            AddInterpreter(@"(?<block>\$(?<contents>.*?)\$)", InlineMathInterpreter);

            // Display math: $$math$$ -> \[math\]
            AddInterpreter(@"(?<block>\$\$(?<contents>.*?)\$\$)", DisplayMathInterpreter);

            // Link: [text](url) -> \href{url}{text}
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Image: ![alt](url) -> \includegraphics[alt]{url}
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", ImageInterpreter);

            // Inline code: `code` -> \texttt{code}
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $"\\textbf{{{contents}}}";

        public string ItalicInterpreter(string contents)
            => $"\\textit{{{contents}}}";

        public string SectionInterpreter(string contents)
            => $"\\section{{{contents}}}";

        public string SubsectionInterpreter(string contents)
            => $"\\subsection{{{contents}}}";

        public string SubsubsectionInterpreter(string contents)
            => $"\\subsubsection{{{contents}}}";

        public string InlineMathInterpreter(string contents)
            => $"\\({contents}\\)";

        public string DisplayMathInterpreter(string contents)
            => $"\\[{contents}\\]";

        public string LinkInterpreter(string contents, string url)
            => $"\\href{{{url}}}{{{contents}}}";

        public string ImageInterpreter(string contents, string url)
            => $"\\includegraphics[alt={contents}]{{{url}}}";

        public string InlineCodeInterpreter(string contents)
            => $"\\texttt{{{contents}}}";
    }

}
