namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to a basic Custom DSL (domain-specific language).
    /// </summary>
    public partial class CustomDslInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public CustomDslInterpreter() : base()
        {
            // Bold text: **text** -> BOLD(text)
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> ITALIC(text)
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Header 1: # Header -> HEADER1(Header)
            AddInterpreter(@"(?<block>^\# (?<contents>.*?)$)", Header1Interpreter);

            // Header 2: ## Header -> HEADER2(Header)
            AddInterpreter(@"(?<block>^\#\# (?<contents>.*?)$)", Header2Interpreter);

            // Header 3: ### Header -> HEADER3(Header)
            AddInterpreter(@"(?<block>^\#\#\# (?<contents>.*?)$)", Header3Interpreter);

            // Link: [text](url) -> LINK(text, url)
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Image: ![alt](url) -> IMAGE(alt, url)
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", ImageInterpreter);

            // Inline code: `code` -> CODE(code)
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);

            // List item: - Item -> LIST_ITEM(Item)
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", ListItemInterpreter);

            // Line breaks: double newline -> NEWLINE
            AddInterpreter(@"(?<block>\n{2,})", LineBreakInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $"BOLD({contents})";

        public string ItalicInterpreter(string contents)
            => $"ITALIC({contents})";

        public string Header1Interpreter(string contents)
            => $"HEADER1({contents})";

        public string Header2Interpreter(string contents)
            => $"HEADER2({contents})";

        public string Header3Interpreter(string contents)
            => $"HEADER3({contents})";

        public string LinkInterpreter(string contents, string url)
            => $"LINK({contents}, {url})";

        public string ImageInterpreter(string contents, string url)
            => $"IMAGE({contents}, {url})";

        public string InlineCodeInterpreter(string contents)
            => $"CODE({contents})";

        public string ListItemInterpreter(string contents)
            => $"LIST_ITEM({contents})";

        public string LineBreakInterpreter()
            => "NEWLINE";
    }

}
