using System;
using System.Collections.Generic;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Static class containing a constant reference to the semantic versions of the MTConnect Standard
    /// </summary>
    public static class SemanticVersions
    {
        /// <summary>
        /// Collection of semantic versions of the MTConnect Standard
        /// </summary>
        public readonly static Dictionary<MTConnectVersion, SemanticVersion> Versions = new Dictionary<MTConnectVersion, SemanticVersion>()
        {
            { MTConnectVersion.v1_0_1, new SemanticVersion(1, 0, 1, new DateTime(2009, 10, 02)) },
            { MTConnectVersion.v1_1, new SemanticVersion(1, 1, 0, new DateTime(2010, 04, 30)) },
            { MTConnectVersion.v1_2, new SemanticVersion(1, 2, 0, new DateTime(2012, 02, 17)) },
            { MTConnectVersion.v1_3, new SemanticVersion(1, 3, 0, new DateTime(2014, 09, 30)) },
            { MTConnectVersion.v1_3_1, new SemanticVersion(1, 3, 1, new DateTime(2015, 06, 11)) },
            { MTConnectVersion.v1_4, new SemanticVersion(1, 4, 0, new DateTime(2018, 03, 31)) },
            { MTConnectVersion.v1_4_1, new SemanticVersion(1, 4, 1, new DateTime(2018, 03, 31)) },
            { MTConnectVersion.v1_5, new SemanticVersion(1, 5, 0, new DateTime(2019, 12, 31)) },
            { MTConnectVersion.v1_5_1, new SemanticVersion(1, 5, 1, new DateTime(2019, 12, 31)) },
            { MTConnectVersion.v1_6, new SemanticVersion(1, 6, 0, new DateTime(2020, 07, 15)) },
            { MTConnectVersion.v1_6_1, new SemanticVersion(1, 6, 1, new DateTime(2020, 07, 15)) },
            { MTConnectVersion.v1_7, new SemanticVersion(1, 7, 0, new DateTime(2021, 02, 25)) },
            { MTConnectVersion.v1_7_1, new SemanticVersion(1, 7, 1, new DateTime(2021, 02, 25)) },
            { MTConnectVersion.v1_8, new SemanticVersion(1, 8, 0, new DateTime(2021, 09, 06)) },
            { MTConnectVersion.v1_8_1, new SemanticVersion(1, 8, 1, new DateTime(2021, 09, 06)) },
            { MTConnectVersion.v2_0, new SemanticVersion(2, 0, 0, new DateTime(2022, 05, 24)) },
            { MTConnectVersion.v2_0_1, new SemanticVersion(2, 0, 1, new DateTime(2022, 05, 24)) },
            { MTConnectVersion.v2_1, new SemanticVersion(2, 1, 0, new DateTime(2023, 01, 14)) },
            { MTConnectVersion.v2_1_1, new SemanticVersion(2, 1, 1, new DateTime(2023, 01, 14)) },
        };

        /// <summary>
        /// Parses the provided <paramref name="version"/> into a semantic lookup <see cref="MTConnectVersion"/>.
        /// </summary>
        /// <param name="version">String representing a semantic version, typically pulled from the XMI model.</param>
        /// <returns>Parsed version of the semantic enum. Returns <c>null</c> if the string could not be parsed.</returns>
        public static MTConnectVersion? FromString(string version)
        {
            if (!version.StartsWith("v", System.StringComparison.OrdinalIgnoreCase))
                version = $"v{version}";

            if (version.Contains("."))
                version = version.Replace('.', '_');

            if (Enum.TryParse(version, out MTConnectVersion semanticVersion))
                return semanticVersion;

            return null;
        }
    }
}
