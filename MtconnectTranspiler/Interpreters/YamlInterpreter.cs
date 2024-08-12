namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to YAML.
    /// </summary>
    public partial class YamlInterpreter : MarkdownInterpreter
    {
        /// <summary>
        /// Constructs the interpreter
        /// </summary>
        public YamlInterpreter() : base()
        {
            AddInterpreter(@"(?<block>^\# (?<contents>.*?))$", HeaderInterpreter);
            AddInterpreter(@"(?<block>^\-\s(?<contents>.*?)$)", ListItemInterpreter);
            AddInterpreter(@"(?<block>\[(?<contents>.*?)\]\((?<url>.*?)\))", LinkInterpreter);
            AddInterpreter(@"(?<block>!\[(?<contents>.*?)\]\((?<url>.*?)\))", ImageInterpreter);
        }

        public string HeaderInterpreter(string contents)
            => $"header: \"{contents}\"";

        public string ListItemInterpreter(string contents)
            => $"- item: \"{contents}\"";

        public string LinkInterpreter(string contents, string url)
            => $"- link:\n    text: \"{contents}\"\n    url: \"{url}\"";

        public string ImageInterpreter(string contents, string url)
            => $"- image:\n    alt: \"{contents}\"\n    src: \"{url}\"";
    }

}
