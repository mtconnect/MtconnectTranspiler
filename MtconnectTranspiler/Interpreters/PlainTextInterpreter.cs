namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to plain text.
    /// </summary>
    public partial class PlainTextInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public PlainTextInterpreter() : base()
        {
            AddInterpreter(@"(?<block>\*\*(?<contents>.*?)\*\*)", RemoveFormatting);
            AddInterpreter(@"(?<block>\*(?<contents>.*?)\*)", RemoveFormatting);
            AddInterpreter(@"(?<block>\# (?<contents>.*?))", RemoveFormatting);
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", RemoveFormatting);
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", RemoveFormatting);
            AddInterpreter(@"(?<block>`(?<contents>.*?)`)", RemoveFormatting);
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", RemoveFormatting);
            AddInterpreter(@"(?<block>\n{2,})", LineBreakInterpreter);
        }

        public string RemoveFormatting(string contents)
            => contents;

        public string LineBreakInterpreter()
            => "\n";
    }

}
