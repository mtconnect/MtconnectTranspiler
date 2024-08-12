namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Hyper Text Markup Language (HTML).
    /// </summary>
    public partial class HtmlInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public HtmlInterpreter() : base()
        {
            // Bold text: **text** -> <strong>text</strong>
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> <em>text</em>
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Header 1: # Header -> <h1>Header</h1>
            AddInterpreter(@"(?<block>^\# (?<contents>.*?)$)", Header1Interpreter);

            // Header 2: ## Header -> <h2>Header</h2>
            AddInterpreter(@"(?<block>^\#\# (?<contents>.*?)$)", Header2Interpreter);

            // Header 3: ### Header -> <h3>Header</h3>
            AddInterpreter(@"(?<block>^\#\#\# (?<contents>.*?)$)", Header3Interpreter);

            // Link: [text](url) -> <a href="url">text</a>
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Image: ![alt](url) -> <img src="url" alt="alt" />
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", ImageInterpreter);

            // Code block: ```code``` -> <code>code</code>
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);

            // Line breaks: double newline -> <br/>
            AddInterpreter(@"(?<block>\n{2,})", LineBreakInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $"<strong>{contents}</strong>";

        public string ItalicInterpreter(string contents)
            => $"<em>{contents}</em>";

        public string Header1Interpreter(string contents)
            => $"<h1>{contents}</h1>";

        public string Header2Interpreter(string contents)
            => $"<h2>{contents}</h2>";

        public string Header3Interpreter(string contents)
            => $"<h3>{contents}</h3>";

        public string LinkInterpreter(string contents, string url)
            => $"<a href=\"{url}\">{contents}</a>";

        public string ImageInterpreter(string contents, string url)
            => $"<img src=\"{url}\" alt=\"{contents}\" />";

        public string InlineCodeInterpreter(string contents)
            => $"<code>{contents}</code>";

        public string LineBreakInterpreter()
            => "<br/>";
    }

}
