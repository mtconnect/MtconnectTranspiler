namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// A common interpreter with overridable methods to capture the SysML markdown.
    /// </summary>
    public abstract class CommonMarkdownInterpreter : MarkdownInterpreter
    {
        /// <inheritdoc />
        public CommonMarkdownInterpreter()
        {
            // Common patterns with abstract methods to enforce implementation
            AddInterpreter(@"(?<block>&#10;)", LineBreakInterpreter);
            AddInterpreter(@"(?<block>`(?<code>.*?)`)", InlineCodeInterpreter);
            AddInterpreter(@"(?<block>\*\*(?<text>.*?)\*\*)", BoldInterpreter);
            AddInterpreter(@"(?<block>\*(?<text>.*?)\*)", EmphasisInterpreter);
            AddInterpreter(@"(?<block>\{\{term\((?<term>.*?)\)\}\})", TermInterpreter);
            AddInterpreter(@"(?<block>\{\{termplural\((?<term>.*?)\)\}\})", TermPluralInterpreter);
            AddInterpreter(@"(?<block>\$\$(?<expression>.*?)\$\$)", MathInterpreter);
            AddInterpreter(@"(?<block>\{\{newacronym\{(?<acronym1>.*?)\}\{(?<acronym2>.*?)\}\{(?<term>.*?)\}\(\)\}\})", NewAcronymInterpreter);
            AddInterpreter(@"(?<block>\{\{block\((?<name>.*?)\)\}\})", BlockInterpreter);
            AddInterpreter(@"(?<block>\{\{url\((?<address>.*?)\)\}\})", UrlInterpreter);
            AddInterpreter(@"(?<block>\{\{def\((?<enumuration>.*?)\:\:(?<value>.*?)\)\}\})", DefInterpreter);
            AddInterpreter(@"(?<block>\{\{cite\((?<citation>.*?)\)\}\})", CiteInterpreter);
            AddInterpreter(@"(?<block>\{\{sect\((?<contents>.*?)\)\}\})", SectInterpreter);
            AddInterpreter(@"(?<block>\{\{package\((?<name>.*?)\)\}\})", PackageInterpreter);
            AddInterpreter(@"(?<block>\{\{appendix\((?<contents>.*?)\)\}\})", AppendixInterpreter);
            AddInterpreter(@"(?<block>\{\{section\*?\{(?<title>.*?)\}\(\)\}\})", SectionInterpreter);
            AddInterpreter(@"(?<block>\{\{property\((?<class_name>.*?)\:\:(?<property_name>.*?)\)\}\})", PropertyInterpreter);
            AddInterpreter(@"(?<block>^(\*|-|\+)\s+(?<contents>.*?))", UnorderedListInterpreter);
            AddInterpreter(@"(?<block>^\d+\.\s+(?<contents>.*?))", OrderedListInterpreter);
            AddInterpreter(@"(?<block>^\>\s+(?<contents>.*?))", QuoteInterpreter);
            AddInterpreter(@"(?<block>```(?<language>.*?)\r\n(?<code>.*?)\r\n```)", CodeBlockInterpreter);
            AddInterpreter(@"(?<block>^\|\s*.*?\s*\|$)", TableInterpreter);

            //AddInterpreter(@"(.*?)(?<block>\{\{newpage\(\)\}\}(?<contents>.*?))(.*?)", UnhandledInterpreter);
            //AddInterpreter(@"(.*?)(?<block>\{\{appendix\((?<contents>.*?)\)\}\})(.*?)", UnhandledInterpreter);
            //AddInterpreter(@"(.*?)(?<block>\{\{section\*\((?<contents>.*?)\)\}\})(.*?)", UnhandledInterpreter);
            //AddInterpreter(@"(.*?)(?<block>\{\{addcontentsline(?<contents>.*?)\}\})(.*?)", UnhandledInterpreter);
            //AddInterpreter(@"(.*?)(?<block>\{\{input(?<contents>.*?)\}\})(.*?)", UnhandledInterpreter);
            //AddInterpreter(@"(.*?)(?<block>\{\{renewcommand(?<contents>.*?)\}\})(.*?)", UnhandledInterpreter);
        }

        /// <summary>
        /// Interprets custom markup tag <c>appendix</c>.
        /// Captures the pattern: <c>{{appendix(contents)}}</c>.
        /// This pattern is typically used to include supplementary material or appendices in the documentation.
        /// </summary>
        /// <param name="contents">Contents of the markup tag.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string AppendixInterpreter(string contents);

        /// <summary>
        /// Interprets custom markup tag <c>block</c>.
        /// Captures the pattern: <c>{{block(name)}}</c>.
        /// This pattern is used to reference a specific block or section within the model or documentation.
        /// </summary>
        /// <param name="name">Reference name of the block.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string BlockInterpreter(string name);

        /// <summary>
        /// Interprets bold text in markdown.
        /// Captures the pattern: <c>**text**</c>.
        /// This pattern is used to emphasize text by making it bold.
        /// </summary>
        /// <param name="text">The text content between the bold markers.</param>
        /// <returns>The bolded text content.</returns>
        public abstract string BoldInterpreter(string text);

        /// <summary>
        /// Interprets custom markup tag <c>cite</c>.
        /// Captures the pattern: <c>{{cite(citation)}}</c>.
        /// This pattern is used to cite or reference an external source within the documentation.
        /// </summary>
        /// <param name="citation">Reference entity (e.g., a document, standard, or source).</param>
        /// <returns>Interpreted string.</returns>
        public abstract string CiteInterpreter(string citation);

        /// <summary>
        /// Interprets a code block in markdown.
        /// Captures the pattern: <c>```language code ```</c>.
        /// This pattern is used to include a block of code in the documentation, optionally specifying a programming language.
        /// </summary>
        /// <param name="language">The optional language definition for the code block.</param>
        /// <param name="code">The code content.</param>
        /// <returns>The code block wrapped in markdown code block syntax.</returns>
        public abstract string CodeBlockInterpreter(string language, string code);

        /// <summary>
        /// Interprets custom markup tag <c>def</c>.
        /// Captures the pattern: <c>{{def(Enumeration::Value)}}</c>.
        /// This pattern is used to define or reference a specific enumeration and its value within the documentation.
        /// </summary>
        /// <param name="enumuration">Target enumeration.</param>
        /// <param name="value">Target enumeration value.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string DefInterpreter(string enumuration, string value);

        /// <summary>
        /// Interprets emphasized text in markdown.
        /// Captures the pattern: <c>*text*</c>.
        /// This pattern is used to emphasize text by making it italic.
        /// </summary>
        /// <param name="text">The text content between the emphasis markers.</param>
        /// <returns>The emphasized text content.</returns>
        public abstract string EmphasisInterpreter(string text);

        /// <summary>
        /// Interprets inline code in markdown.
        /// Captures the pattern: <c>`code`</c>.
        /// This pattern is used to display inline code or code snippets within the documentation.
        /// </summary>
        /// <param name="code">The code content between the backticks.</param>
        /// <returns>The code content in plain text.</returns>
        public abstract string InlineCodeInterpreter(string code);

        /// <summary>
        /// Interprets a line break (newline) in markdown.
        /// Captures the pattern: <c>&amp;#10;</c>.
        /// This pattern is used to insert a line break or newline in the documentation.
        /// </summary>
        /// <returns>A newline character.</returns>
        public abstract string LineBreakInterpreter();

        /// <summary>
        /// Interprets a mathematical expression in markdown.
        /// Captures the pattern: <c>$$math$$</c>.
        /// This pattern is used to include a mathematical expression or formula within the documentation.
        /// </summary>
        /// <param name="expression">The math content.</param>
        /// <returns>The math content in plain text.</returns>
        public abstract string MathInterpreter(string expression);

        /// <summary>
        /// Interprets a new acronym in markdown.
        /// Captures the pattern: <c>{{newacronym{acronym1}{acronym2}{term}()}}</c>.
        /// This pattern is used to define a new acronym and its corresponding term in the documentation.
        /// </summary>
        /// <param name="acronym1">The acronym text.</param>
        /// <param name="acronym2">The acronym's expanded form.</param>
        /// <param name="term">The acronym's definition.</param>
        /// <returns>The acronym with its definition.</returns>
        public abstract string NewAcronymInterpreter(string acronym1, string acronym2, string term);

        /// <summary>
        /// Interprets an ordered list item in markdown.
        /// Captures the pattern: <c>1. item</c>, <c>2. item</c>, etc.
        /// This pattern is used to create an ordered list, where each item is prefixed with a number.
        /// </summary>
        /// <param name="contents">The list item content.</param>
        /// <returns>The list item prefixed with a number.</returns>
        public abstract string OrderedListInterpreter(string contents);

        /// <summary>
        /// Interprets custom markup tag <c>package</c>.
        /// Captures the pattern: <c>{{package(name)}}</c>.
        /// This pattern is used to reference a specific package within the SysML model or documentation.
        /// </summary>
        /// <param name="name">Reference name of the package.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string PackageInterpreter(string name);

        /// <summary>
        /// Interprets custom markup tag <c>property</c>.
        /// Captures the pattern: <c>{{property(Class::Property)}}</c>.
        /// This pattern is used to reference a specific property of a class within the SysML model or documentation.
        /// </summary>
        /// <param name="class_name">Name of the class definition.</param>
        /// <param name="property_name">Name of the property.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string PropertyInterpreter(string class_name, string property_name);

        /// <summary>
        /// Interprets a blockquote in markdown.
        /// Captures the pattern: <c>&gt; quote</c>.
        /// This pattern is used to include a quoted block of text in the documentation.
        /// </summary>
        /// <param name="contents">The quoted content.</param>
        /// <returns>The quoted content prefixed with a blockquote marker.</returns>
        public abstract string QuoteInterpreter(string contents);

        /// <summary>
        /// Interprets custom markup tag <c>sect</c>.
        /// Captures the pattern: <c>{{sect(contents)}}</c>.
        /// This pattern is used to define or reference a section within the documentation.
        /// </summary>
        /// <param name="contents">Contents of the markup tag.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string SectInterpreter(string contents);

        /// <summary>
        /// Interprets custom markup tag <c>section</c>.
        /// Captures the pattern: <c>{{section(title)}}</c>.
        /// This pattern is used to define or reference a major section within the documentation.
        /// </summary>
        /// <param name="title">Title of the section.</param>
        /// <returns>Interpreted string.</returns>
        public abstract string SectionInterpreter(string title);

        /// <summary>
        /// Interprets a table row in markdown.
        /// Captures the pattern: <c>| column1 | column2 | ... |</c>.
        /// This pattern is used to represent a row within a table, typically part of a larger table structure.
        /// </summary>
        /// <param name="contents">The table row content.</param>
        /// <returns>The table content without borders.</returns>
        public abstract string TableInterpreter(string contents);

        /// <summary>
        /// Interprets a term in markdown.
        /// Captures the pattern: <c>{{term(content)}}</c>.
        /// This pattern is used to define or reference a specific term within the documentation.
        /// </summary>
        /// <param name="term">The term content.</param>
        /// <returns>The term content in plain text.</returns>
        public abstract string TermInterpreter(string term);

        /// <summary>
        /// Interprets a plural term in markdown.
        /// Captures the pattern: <c>{{termplural(content)}}</c>.
        /// This pattern is used to define or reference a plural term within the documentation.
        /// </summary>
        /// <param name="term">The plural term content.</param>
        /// <returns>The pluralized term content.</returns>
        public abstract string TermPluralInterpreter(string term);

        /// <summary>
        /// Interprets an unordered list item in markdown.
        /// Captures the pattern: <c>* item</c>, <c>- item</c>, or <c>+ item</c>.
        /// This pattern is used to create an unordered list, where each item is prefixed with a bullet point.
        /// </summary>
        /// <param name="contents">The list item content.</param>
        /// <returns>The list item prefixed with a bullet point.</returns>
        public abstract string UnorderedListInterpreter(string contents);

        /// <summary>
        /// Interprets a hyperlink in markdown.
        /// Captures the pattern: <c>{{url(address)}}</c>.
        /// This pattern is used to define or reference a URL or link within the documentation.
        /// </summary>
        /// <param name="address">The URL or link text.</param>
        /// <returns>The hyperlink content in plain text.</returns>
        public abstract string UrlInterpreter(string address);
    }
}
