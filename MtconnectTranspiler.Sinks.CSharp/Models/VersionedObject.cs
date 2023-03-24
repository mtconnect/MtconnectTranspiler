using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" /> which also might have normative versioning.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="XmiElement" />.</typeparam>
    public abstract class VersionedObject : XmiModel<XmiElement>
    {
        /// <summary>
        /// The version of MTConnect when this became normative.
        /// </summary>
        public string NormativeVersion { get; }

        /// <summary>
        /// The version of MTConnect when this became deprecated.
        /// </summary>
        public string DeprecatedVersion { get; }

        public VersionedObject(MTConnectModel model, XmiElement source) : base(source)
        {
            var normative = model?.NormativeReferences?.FirstOrDefault(o => o.BaseElement == Source.Id);
            if (normative != null)
            {
                NormativeVersion = MTConnectHelperMethods.LookupMtconnectVersions(normative.Version);
                var deprecated = model?.DeprecatedReferences?.FirstOrDefault(o => o.BaseElement == Source.Id);
                if (deprecated != null)
                {
                    DeprecatedVersion = MTConnectHelperMethods.LookupMtconnectVersions(deprecated.Version);
                }
            }
        }
    }
}
