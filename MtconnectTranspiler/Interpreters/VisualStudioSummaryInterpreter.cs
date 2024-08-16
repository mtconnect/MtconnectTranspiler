namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter that converts the SysML markdown to Visual Studio code summary comments.
    /// </summary>
    public partial class VisualStudioSummaryInterpreter : CommonMarkdownInterpreter
    {
        /// <inheritdoc />
        public VisualStudioSummaryInterpreter() : base() { }

        /// <inheritdoc />
        public override string Interpret(string input)
        {
            input = input.Replace("&#10;", "\r\n").Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
            return base.Interpret(input);
        }

        /// <inheritdoc />
        public override string AppendixInterpreter(string contents)
            => UnhandledInterpreter(contents);

        /// <inheritdoc />
        public override string BlockInterpreter(string name)
            => CrefInterpreter(name);

        /// <inheritdoc />
        public override string BoldInterpreter(string text)
            => $"<b>{text}</b>";

        /// <inheritdoc />
        public override string CiteInterpreter(string citation)
            => $"<seealso href=\"https://www.google.com/search?q={citation}&amp;btnI=I\">{citation}</seealso>";

        /// <inheritdoc />
        public override string CodeBlockInterpreter(string language, string code)
            => $"<code>{code}</code>";

        /// <inheritdoc />
        public string CrefInterpreter(string name)
            => $"<see cref=\"{name}\">{name}</see>";

        /// <inheritdoc />
        public override string DefInterpreter(string enumuration, string value)
            => CrefInterpreter($"{enumuration}.{value}");

        /// <inheritdoc />
        public override string EmphasisInterpreter(string text)
            => $"<i>{text}</i>";

        /// <inheritdoc />
        public string EmphasisPluralInterpreter(string text)
            => EmphasisInterpreter(text) + "s";

        /// <inheritdoc />
        public override string InlineCodeInterpreter(string code)
            => $"<c>{code}</c>";

        /// <inheritdoc />
        public override string LineBreakInterpreter()
            => "<br/>";

        /// <inheritdoc />
        public override string MathInterpreter(string expression)
            => EmphasisInterpreter(expression);

        /// <inheritdoc />
        public override string NewAcronymInterpreter(string acronym1, string acronym2, string term)
            => EmphasisInterpreter($"{acronym2} ({acronym1})");

        /// <inheritdoc />
        public override string OrderedListInterpreter(string contents)
            => $"<list type=\"number\"><item>{contents}</item></list>";

        /// <inheritdoc />
        public override string PackageInterpreter(string name)
            => CrefInterpreter(name);

        /// <inheritdoc />
        public override string PropertyInterpreter(string class_name, string property_name)
            => $"<see cref=\"{class_name}.{property_name}\">{property_name} in {class_name}</see>";

        /// <inheritdoc />
        public override string QuoteInterpreter(string contents)
            => $"<para>{contents}</para>";

        /// <inheritdoc />
        public override string SectInterpreter(string contents)
            => CrefInterpreter(contents);

        /// <inheritdoc />
        public override string SectionInterpreter(string title)
            => UnhandledInterpreter(title);

        /// <inheritdoc />
        public override string TableInterpreter(string contents)
            => $"<para>{contents.Replace("|", "").Replace("\n", "<br/>")}</para>";

        /// <inheritdoc />
        public override string TermInterpreter(string term)
            => EmphasisInterpreter(term);

        /// <inheritdoc />
        public override string TermPluralInterpreter(string term)
            => EmphasisPluralInterpreter(term);

        /// <summary>
        /// <inheritdoc cref="VisualStudioSummaryInterpreter" path="/interpreter"/>
        /// </summary>
        /// <param name="contents">
        /// <inheritdoc cref="VisualStudioSummaryInterpreter" path="/interpreter_input"/>
        /// </param>
        /// <returns><c>&lt;!-- XML comment --&gt;</c></returns>
        public string UnhandledInterpreter(string contents)
            => $"<!-- UNHANDLED MARKDOWN: {contents} -->";

        /// <inheritdoc />
        public override string UnorderedListInterpreter(string contents)
            => $"<list type=\"bullet\"><item>{contents}</item></list>";

        /// <inheritdoc />
        public override string UrlInterpreter(string address)
            => $"<see href=\"{address}\">{address}</see>";
    }
}
