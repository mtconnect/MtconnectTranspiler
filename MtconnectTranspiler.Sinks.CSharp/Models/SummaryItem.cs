using MtconnectTranspiler.Xmi;
namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class SummaryItem : XmiModel<OwnedComment>
    {
        public SummaryItem(OwnedComment source) : base(source)
        {
        }

        public override string ToString()
        {
            return $"/// {ScribanHelperMethods.ToSummary(Source.Body)}";
        }
    }
}
