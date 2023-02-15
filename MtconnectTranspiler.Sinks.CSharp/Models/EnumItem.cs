using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class EnumItem : VersionedObject
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; private set; }

        public string Name => ScribanHelperMethods.ToSnakeCase(base.SysML_Name);

        public EnumItem(MTConnectModel model, UmlEnumerationLiteral source) : base(model, source)
        {
            if (source?.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
        public EnumItem(MTConnectModel model, UmlClass source) : base(model, source)
        {
            if (source?.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
    }
}
