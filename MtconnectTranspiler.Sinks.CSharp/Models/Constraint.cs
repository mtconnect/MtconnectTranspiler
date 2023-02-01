using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class Constraint : VersionedObject
    {
        public string Name => base.SysML_Name.ToPascalCase();

        public string SourceLanguage { get; set; } = "Unspecified";

        public string RawScript { get; set; }

        public Constraint(MTConnectModel model, UmlConstraint source) : base(model, source)
        {
            SourceLanguage = source.Specification?.Language;
            RawScript = source.Specification?.Body;
        }
    }
}
