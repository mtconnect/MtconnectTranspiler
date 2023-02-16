using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.Profile;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MtconnectTranspiler.Contracts
{
    public static class MTConnectHelper
    {
        /// <summary>
        /// Lookup table for each released version of MTConnect and the respective GitHub tags in the SysML model repository.
        /// </summary>
        /// <remarks>TODO: Keep this dictionary up-to-date with each release. <see href="https://api.github.com/repos/mtconnect/mtconnect_sysml_model/releases"/>.</remarks>
        public static Dictionary<MTConnectVersions, string> VersionGitTags { get; } = new Dictionary<MTConnectVersions, string>()
        {
            { MTConnectVersions.v1_0, "v1.5" },
            { MTConnectVersions.v1_1, "v1.5" },
            { MTConnectVersions.v1_2, "v1.5" },
            { MTConnectVersions.v1_3, "v1.5" },
            { MTConnectVersions.v1_4, "v1.5" },
            { MTConnectVersions.v1_5, "v1.5" },
            { MTConnectVersions.v1_6, "v1.6" },
            { MTConnectVersions.v1_7, "v1.7" },
            { MTConnectVersions.v1_8, "v1.8" },
            { MTConnectVersions.v2_0, "v2.0" },
            { MTConnectVersions.v2_1, "v2.1" },
        };

        /// <summary>
        /// Builds the reference address for a released version of the SysML model on GitHub.
        /// </summary>
        /// <param name="version">Reference to the MTConnect Version to lookup</param>
        /// <returns>Formatted URI to download the XML of the SysML model for the requested version of MTConnect.</returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public static Uri BuildModelUri(MTConnectVersions version)
        {
            if (!VersionGitTags.TryGetValue(version, out string tag)) throw new KeyNotFoundException();
            return BuildModelUri(tag);
        }

        /// <summary>
        /// Builds the reference address for a released version of the SysML model on GitHub.
        /// </summary>
        /// <param name="tag">The raw tag name of the released version on GitHub.</param>
        /// <returns><inheritdoc cref="BuildModelUri(MTConnectVersions)" path="/returns"/></returns>
        public static Uri BuildModelUri(string tag)
            => tag.Equals("latest", StringComparison.OrdinalIgnoreCase)
            ? new Uri($"https://github.com/mtconnect/mtconnect_sysml_model/releases/latest/download/Model.xml")
            : new Uri($"https://github.com/mtconnect/mtconnect_sysml_model/releases/download/{tag}/Model.xml");

        public static Normative? LookupNormative(MTConnectModel model, string id)
            => model.NormativeReferences.FirstOrDefault(o => o.BaseElement == id);
        public static Deprecated? LookupDeprecated(MTConnectModel model, string id)
            => model.DeprecatedReferences.FirstOrDefault(o => o.BaseElement == id);

    }
}
