using MtconnectTranspiler.Xmi;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MtconnectTranspiler.Interpreters
{
    /// <summary>
    /// An interpreter class for translating the Markdown defined in the XMI document's "Comments" into other documentation forms.
    /// </summary>
    public abstract class MarkdownInterpreter
    {
        /// <summary>
        /// An internal collection of Regex-based interpreters.
        /// </summary>
        // Updated to use Delegate for more dynamic method signatures
        protected readonly List<(Regex regex, Delegate interpreter, string targetGroup)> interpreters = new List<(Regex, Delegate, string)>();


        /// <summary>
        /// Constructs a new instance of a Markdown interpreter
        /// </summary>
        public MarkdownInterpreter() { }

        /// <summary>
        /// Adds a new interpreter for string processing. Note: The default string replacement processes <c>block</c> and <c>contents</c> groupings by replacing instances of <c>block</c> with <c>contents</c>.
        /// </summary>
        /// <param name="regex">The regex used to determine if this interpreter applies to the input string.</param>
        /// <param name="interpreter">A function that will translate the input text into the expected format.</param>
        /// <param name="targetGroup">Refers to the Regex capture group that encapsulates the string to be replaced by the interpreted string.</param>
        private void AddInterpreter(Regex regex, Delegate interpreter, string targetGroup = "block")
        {
            interpreters.Add((regex, interpreter, targetGroup));
        }

        private void AddInterpreter(string expression, Delegate interpreter, string targetGroup = "block")
            => AddInterpreter(new Regex(expression), interpreter, targetGroup);


        /// <summary>
        /// Evaluates the input text against all interpreters and performs text replacement when matches are found.
        /// </summary>
        /// <param name="input">The markdown from the XMI comments.</param>
        /// <returns>Interpreted string</returns>
        public virtual string Interpret(string input)
        {
            StringBuilder output = new StringBuilder(input);

            foreach (var (regex, interpreter, targetGroup) in interpreters)
            {
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var parameters = BuildParameters(interpreter.Method, match);
                    var result = interpreter.DynamicInvoke(parameters.ToArray())?.ToString() ?? string.Empty;

                    // Replace the target group with the result
                    output = output.Replace(match.Groups[targetGroup].Value, result);
                }
            }

            return output.ToString();
        }

        // Helper method to build parameters for the interpreter function
        private static List<object> BuildParameters(MethodInfo method, Match match)
        {
            var parameters = new List<object>();

            foreach (var parameter in method.GetParameters())
            {
                var group = match.Groups[parameter.Name];
                if (group != null)
                {
                    parameters.Add(group.Value);
                }
                else
                {
                    parameters.Add(string.Empty); // Default to an empty string if the group doesn't exist
                }
            }

            return parameters;
        }

        /// <summary>
        /// Evaluates the input text against all interpreters and performs text replacement when matches are found.
        /// </summary>
        /// <param name="comment">Composes markdown for a <c>uml:Comment</c>.</param>
        /// <returns>Interpreted string.</returns>
        public virtual string Interpret(OwnedComment comment)
            => Interpret(composeComment(comment));

        private string composeComment(OwnedComment comment, int headerDepth = 1)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(comment.Name))
            {
                string headerPrefix = new string('#', headerDepth);
                sb.AppendLine($"{headerPrefix} {comment.Name}&#10;");
            }
            sb.AppendLine(comment.Body + "&#10;");
            if (comment.SubComment != null)
            {
                sb.AppendLine(composeComment(comment.SubComment, headerDepth + 1) + "&#10;");
            }
            return sb.ToString();
        }

        #region Nothing to see here...
        // 0 parameters
        public void AddInterpreter(Regex regex, Func<string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 1 parameter
        public void AddInterpreter(Regex regex, Func<string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter);
        // 2 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 3 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 4 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 5 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 6 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 7 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 8 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 9 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 10 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 11 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 12 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 13 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 14 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 15 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        // 16 parameters
        public void AddInterpreter(Regex regex, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(regex, interpreter as Delegate);
        public void AddInterpreter(string expression, Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> interpreter) => AddInterpreter(new Regex(expression), interpreter as Delegate);
        #endregion
    }

}
