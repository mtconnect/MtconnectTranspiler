using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [ScribanTemplate("Enum.scriban")]
    public class Enum : VersionedObject, IFileSource
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary? Summary { get; private set; }

        /// <inheritdoc />
        public string Name => ScribanHelperMethods.ToPascalCase(base.SysML_Name);

        /// <summary>
        /// Collection of Enum values
        /// </summary>
        public EnumItem[]? Items { get; }

        /// <inheritdoc />
        public string Filename { get; set; }

        /// <inheritdoc />
        public string Namespace { get; set; }

        public Enum(MTConnectModel model, UmlEnumeration source) : base(model, source)
        {
            Filename = $"{Name}.cs";
            Items = source.Items
                ?.Select(o => new EnumItem(model, o))
                ?.ToArray();
        }
        public Enum(MTConnectModel model, UmlPackage source) : base(model, source)
        {
            Filename = $"{Name}.cs";
            Items = source.Elements
                ?.Where(o => o is UmlClass)
                ?.Select(o => new EnumItem(model, (UmlClass)o))
                ?.ToArray();
            
            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
        public Enum(MTConnectModel model, MTConnectDeviceInformationModel source) : base(model, source)
        {
            Filename = $"{Name}.cs";
            Items = source.Classes
                ?.Select(o => new EnumItem(model, (UmlClass)o))
                ?.ToArray();

            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }

    }
}
