namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Swagger/OpenAPI Documentation.
    /// </summary>
    public partial class SwaggerInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public SwaggerInterpreter() : base()
        {
            // Bold text: **text** -> **text**
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> *text*
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Inline Code: `code` -> `code`
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);

            // Link: [text](url) -> [text](url)
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Headers: # Header -> ### Header
            AddInterpreter(@"(?<block>^\# (?<contents>.*?)$)", Header1Interpreter);
            AddInterpreter(@"(?<block>^\#\# (?<contents>.*?)$)", Header2Interpreter);
            AddInterpreter(@"(?<block>^\#\#\# (?<contents>.*?)$)", Header3Interpreter);

            // Lists: - Item -> * Item
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", ListItemInterpreter);

            // Line breaks: double newline -> \n\n
            AddInterpreter(@"(?<block>\n{2,})", LineBreakInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $"**{contents}**";

        public string ItalicInterpreter(string contents)
            => $"*{contents}*";

        public string InlineCodeInterpreter(string contents)
            => $"`{contents}`";

        public string LinkInterpreter(string contents, string url)
            => $"[{contents}]({url})";

        public string Header1Interpreter(string contents)
            => $"### {contents}";

        public string Header2Interpreter(string contents)
            => $"#### {contents}";

        public string Header3Interpreter(string contents)
            => $"##### {contents}";

        public string ListItemInterpreter(string contents)
            => $"* {contents}";

        public string LineBreakInterpreter()
            => "\n\n";
    }

}
