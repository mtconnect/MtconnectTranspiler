namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Rich Text Format (RTF).
    /// </summary>
    public partial class RtfInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public RtfInterpreter() : base()
        {
            // Bold text: **text** -> \b text\b0
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> \i text\i0
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Header 1: # Header -> \fs48\b Header\b0\fs24
            AddInterpreter(@"(?<block>^\# (?<contents>.*?)$)", Header1Interpreter);

            // Header 2: ## Header -> \fs36\b Header\b0\fs24
            AddInterpreter(@"(?<block>^\#\# (?<contents>.*?)$)", Header2Interpreter);

            // Header 3: ### Header -> \fs28\b Header\b0\fs24
            AddInterpreter(@"(?<block>^\#\#\# (?<contents>.*?)$)", Header3Interpreter);

            // Link: [text](url) -> \ul text\ulnone
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Image: ![alt](url) -> (Images are typically handled outside basic RTF, so this might be custom)
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", ImageInterpreter);

            // Inline code: `code` -> \f1 code\f0 (assuming \f1 is a monospace font)
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);

            // List item: - Item -> \bullet Item
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", ListItemInterpreter);

            // Line breaks: double newline -> \par
            AddInterpreter(@"(?<block>\n{2,})", LineBreakInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $@"\b {contents}\b0";

        public string ItalicInterpreter(string contents)
            => $@"\i {contents}\i0";

        public string Header1Interpreter(string contents)
            => $@"\fs48\b {contents}\b0\fs24";

        public string Header2Interpreter(string contents)
            => $@"\fs36\b {contents}\b0\fs24";

        public string Header3Interpreter(string contents)
            => $@"\fs28\b {contents}\b0\fs24";

        public string LinkInterpreter(string contents, string url)
            => $@"\ul {contents}\ulnone"; // In basic RTF, links are not clickable; underline is used.

        public string ImageInterpreter(string contents, string url)
            => $@"{{\field{{\*\fldinst INCLUDEPICTURE ""{url}"" \d }}{{\fldrslt {contents}}}}}"; // Basic RTF image placeholder

        public string InlineCodeInterpreter(string contents)
            => $@"\f1 {contents}\f0"; // Assuming \f1 is a monospace font, \f0 returns to the default font

        public string ListItemInterpreter(string contents)
            => $@"\bullet {contents}";

        public string LineBreakInterpreter()
            => @"\par";
    }

}
