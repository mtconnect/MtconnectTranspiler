using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class Property : VersionedObject
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary? Summary { get; private set; }

        public string Name => base.SysML_Name.ToPascalCase();

        /// <summary>
        /// Reference to the access modifier for the property. Default is <c>public</c>
        /// </summary>
        public string AccessModifier { get; set; } = "public";

        /// <summary>
        /// Reference to the expected property type
        /// </summary>
        public string Type { get; set; }

        public Property(MTConnectModel model, UmlProperty source) : base(model, source)
        {
            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }

            AccessModifier = source.Visibility;

            Type = MTConnectHelperMethods.LookupCsharpDataType(model, source);
        }
    }
}
