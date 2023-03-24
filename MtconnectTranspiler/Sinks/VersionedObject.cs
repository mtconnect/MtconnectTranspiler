using MtconnectTranspiler.Xmi;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" /> which also might have normative versioning.
    /// </summary>
    public abstract class VersionedObject : XmiModel<XmiElement>
    {
        /// <summary>
        /// The version of MTConnect when this became normative.
        /// </summary>
        public string NormativeVersion { get; } = string.Empty;

        /// <summary>
        /// The version of MTConnect when this became deprecated.
        /// </summary>
        public string DeprecatedVersion { get; } = string.Empty;

        /// <summary>
        /// Constructs a new instance of the <see cref="VersionedObject"/>.
        /// </summary>
        /// <param name="model">Reference to the high-level <see cref="XmiDocument"/>.</param>
        /// <param name="source">Reference to the source <see cref="XmiElement"/> that may have Normative and Deprecated references in the XMI model.</param>
        public VersionedObject(XmiDocument model, XmiElement source) : base(source)
        {
            var normative = model?.NormativeIntroductions?.FirstOrDefault(o => o.BaseElement == Source.Id);
            if (normative != null)
            {
                NormativeVersion = lookupMtconnectVersion(normative.Version);
                var deprecated = model?.Deprecations?.FirstOrDefault(o => o.BaseElement == Source.Id);
                if (deprecated != null)
                {
                    DeprecatedVersion = lookupMtconnectVersion(deprecated.Version);
                }
            }
        }

        /// <summary>
        /// Looks up the appropriate representation of MTConnect Standard version in the current context.
        /// </summary>
        /// <param name="version">Reference to the version of MTConnect Standard as labeled in the XMI model. For example, <c>1.0</c> or <c>2.1</c>.</param>
        /// <returns>The representation of the MTConnect Standard version in the current context.</returns>
        protected abstract string lookupMtconnectVersion(string? version);
    }
}
