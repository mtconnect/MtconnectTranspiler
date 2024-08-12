namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Javadoc comments.
    /// </summary>
    public partial class JavadocInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public JavadocInterpreter() : base()
        {
            // Bold text: **text** -> <b>text</b>
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", BoldInterpreter);

            // Italic text: *text* -> <i>text</i>
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", ItalicInterpreter);

            // Code block: `code` -> <code>code</code>
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", InlineCodeInterpreter);

            // Link: [text](url) -> {@link url text}
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);

            // Inline Math: $math$ -> <code>math</code>
            AddInterpreter(@"(?<block>\$(?<contents>.*?)\$)", InlineMathInterpreter);

            // List item: - Item -> <li>Item</li>
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", ListItemInterpreter);

            // Paragraphs: Multiple new lines -> <p>Text</p>
            AddInterpreter(@"(?<block>\n{2,})", ParagraphInterpreter);
        }

        public string BoldInterpreter(string contents)
            => $"<b>{contents}</b>";

        public string ItalicInterpreter(string contents)
            => $"<i>{contents}</i>";

        public string InlineCodeInterpreter(string contents)
            => $"<code>{contents}</code>";

        public string LinkInterpreter(string contents, string url)
            => $"{{@link {url} {contents}}}";

        public string InlineMathInterpreter(string contents)
            => $"<code>{contents}</code>";

        public string ListItemInterpreter(string contents)
            => $"<li>{contents}</li>";

        public string ParagraphInterpreter()
            => "<p>";
    }

}
