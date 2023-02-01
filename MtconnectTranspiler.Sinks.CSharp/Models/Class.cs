using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [ScribanTemplate("Class.scriban")]
    public class Class : VersionedObject, IFileSource
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary? Summary { get; private set; }

        public string Name => base.SysML_Name.ToPascalCase();

        /// <inheritdoc />
        public string Filename { get; set; }

        /// <inheritdoc />
        public string Namespace { get; set; }

        public string? Modifier { get; set; }

        public Property[] Items { get; set; }

        public Constraint[] Constraints { get; set; }

        public Class(MTConnectModel model, UmlClass source) : base(model, source)
        {
            Filename = $"{Name}.cs";

            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }

            if (source.IsAbstract)
            {
                Modifier = "abstract";
            }

            Items = source.Properties
                ?.Select(o => new Property(model, o))
                ?.ToArray();

            Constraints = source.Constraints
                ?.Select(o => new Constraint(model, o))
                ?.ToArray();
        }
    }
}
