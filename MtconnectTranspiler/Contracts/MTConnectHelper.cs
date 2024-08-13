using MtconnectTranspiler.Contracts.Navigation;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Helper methods for navigating the XMI document relative to the MTConnect Standard structure.
    /// </summary>
    /// <remarks>This helper class contains internal caches that do not support multiple different XMI sources without first clearing the cache.</remarks>
    public static class MTConnectHelper
    {
        /// <summary>
        /// A tree structure that outlines the <c>&lt;packagedElement xmi:type='uml:Package' /&gt;</c> element structure in the XMI document.
        /// </summary>
        /// <remarks>Meant to be used in combination with <see cref="JumpToPackage(XmiDocument, string)"/></remarks>
        public static ModelNavigation PackageNavigationTree { get; } = new ModelNavigation();

        /// <summary>
        /// Lookup table for each released version of MTConnect and the respective GitHub tags in the SysML model repository.
        /// </summary>
        /// <remarks>TODO: Keep this dictionary up-to-date with each release. <see href="https://api.github.com/repos/mtconnect/mtconnect_sysml_model/releases"/>.</remarks>
        public static Dictionary<MTConnectVersion, string> VersionGitTags { get; } = new Dictionary<MTConnectVersion, string>()
        {
            { MTConnectVersion.v1_0_1, "v1.5" },
            { MTConnectVersion.v1_1, "v1.5" },
            { MTConnectVersion.v1_2, "v1.5" },
            { MTConnectVersion.v1_3, "v1.5" },
            { MTConnectVersion.v1_4, "v1.5" },
            { MTConnectVersion.v1_5, "v1.5" },
            { MTConnectVersion.v1_6, "v1.6" },
            { MTConnectVersion.v1_7, "v1.7" },
            { MTConnectVersion.v1_8, "v1.8" },
            { MTConnectVersion.v2_0, "v2.0" },
            { MTConnectVersion.v2_1, "v2.1" },
            { MTConnectVersion.v2_2, "v2.2" },
            { MTConnectVersion.v2_3, "v2.3" },
            { MTConnectVersion.v2_4, "v2.4" },
            { MTConnectVersion.v2_5, "v2.5" },
        };

        /// <summary>
        /// Builds the reference address for a released version of the SysML model on GitHub.
        /// </summary>
        /// <param name="version">Reference to the MTConnect Version to lookup</param>
        /// <returns>Formatted URI to download the XML of the SysML model for the requested version of MTConnect.</returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public static Uri BuildModelGitHubUri(MTConnectVersion version)
        {
            if (!VersionGitTags.TryGetValue(version, out string tag)) throw new KeyNotFoundException();
            return BuildModelGitHubUri(tag);
        }
        /// <summary>
        /// Builds the reference address for a released version of the SysML model on GitHub.
        /// </summary>
        /// <param name="tag">The raw tag name of the released version on GitHub.</param>
        /// <returns><inheritdoc cref="BuildModelGitHubUri(MTConnectVersion)" path="/returns"/></returns>
        public static Uri BuildModelGitHubUri(string tag)
            => tag.Equals("latest", StringComparison.OrdinalIgnoreCase)
            ? new Uri($"https://github.com/mtconnect/mtconnect_sysml_model/releases/latest/download/Model.xml")
            : new Uri($"https://github.com/mtconnect/mtconnect_sysml_model/releases/download/{tag}/Model.xml");

        private static Dictionary<string, int>? NormativeCache = null;
        /// <summary>
        /// Finds the <see cref="Normative"/> based on the <see cref="Normative.BaseElement"/> matching the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="model">Reference to the deserialized model</param>
        /// <param name="id">Lookup key</param>
        /// <returns><see cref="Normative"/> model that matches. Returns <c>null</c> if not found.</returns>
        public static Normative? LookupNormative(this XmiDocument model, string? id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            NormativeCache ??= model.Introductions?.Select((o, i) => (o.BaseElement, i))?.ToDictionary(o => o.BaseElement!, o => o.i);

            if (NormativeCache != null && NormativeCache.TryGetValue(id!, out int index))
                return model.Introductions?.ElementAt(index);
            return null;
        }

        private static Dictionary<string, int>? DeprecatedCache = null;
        /// <summary>
        /// Finds the <see cref="Deprecated"/> based on the <see cref="Deprecated.BaseElement"/> matching the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="model">Reference to the deserialized model</param>
        /// <param name="id">Lookup key</param>
        /// <returns><see cref="Deprecated"/> model that matches. Returns <c>null</c> if not found.</returns>
        public static Deprecated? LookupDeprecated(this XmiDocument model, string? id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            DeprecatedCache ??= model.Deprecations?.Select((o, i) => (o.BaseElement, i))?.ToDictionary(o => o.BaseElement!, o => o.i);

            if (DeprecatedCache != null && DeprecatedCache.TryGetValue(id!, out int index))
                return model.Deprecations?.ElementAt(index);
            return null;
        }

        /// <summary>
        /// Finds the <see cref="UmlDataType"/> based on the <c>xmi:id</c> matching the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="model">Reference to the deserialized model</param>
        /// <param name="id">Lookup key</param>
        /// <returns><see cref="UmlDataType"/> model that matches. Returns <c>null</c> if not found.</returns>
        public static UmlDataType? LookupDataType(this XmiDocument model, string? id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            return model.JumpToPackage(PackageNavigationTree.Profile.DataTypes)?.DataTypes.GetById(id);
        }

        /// <summary>
        /// Searches for a <see cref="UmlPackage"/> using the specified <paramref name="navigationPath"/>.
        /// </summary>
        /// <param name="model">Reference to the deserialized XMI document model.</param>
        /// <param name="navigationPath">A dot-separated path to the <see cref="UmlPackage"/> starting from the <see cref="XmiDocument.Model"/>, searching by name. See also <seealso cref="PackageNavigationTree"/> for available options for <paramref name="navigationPath"/>.</param>
        /// <returns>Found <see cref="UmlPackage"/>, otherwise returns <c>null</c></returns>
        public static UmlPackage? JumpToPackage(this XmiDocument model, string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException(nameof(navigationPath));

            string[] paths = navigationPath.Split('.');

            UmlPackage? package = null;
            PackagedElementCollection<UmlPackage>? packages;
            if (paths[0].Equals("Profile"))
            {
                if (paths.Length <= 1)
                    throw new ArgumentException(nameof(navigationPath), "Navigation path must contain more than a reference to 'Profile'");

                packages = model.Model?.Profiles.GetByName("Profile").Packages;
            } else
            {
                package = model.Model?.Packages.GetByName(paths[0]);
                packages = package?.Packages;
            }

            if (packages != null && paths.Length > 1)
            {
                // model.Model.Packages;
                for (int i = 1; i < paths.Length; i++)
                {
                    UmlPackage? pathResult = packages.GetByName(paths[i]);
                    if (pathResult != null)
                    {
                        packages = pathResult.Packages;
                        package = pathResult;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return package;
        }
    
        /// <summary>
        /// Clears all internal caches in this helper class.
        /// </summary>
        public static void ClearCache()
        {
            NormativeCache?.Clear();
            NormativeCache = null;

            DeprecatedCache?.Clear();
            DeprecatedCache = null;
        }
    }
}
