using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using System.Text;
using System.Text.RegularExpressions;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [ScribanTemplate("UmlCommentsSummaryContent.scriban")]
    public class Summary
    {
        public SummaryItem[] Items { get; }

        public Summary(OwnedComment[]? comments)
        {
            Items = comments?.Select(o => new SummaryItem(o))?.ToArray();
        }

        public override string ToString()
        {
            Regex removeLines = new Regex(@"\r\n|\n|\r", RegexOptions.Compiled);
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.Append(removeLines.Replace(item.ToString(), " "));
            }
            return sb.ToString();
        }
    }
}
