using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.Profile;
using MtconnectTranspiler.Xmi.UML;
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
            return new Uri($"https://github.com/mtconnect/mtconnect_sysml_model/releases/download/{tag}/Model.xml");
        }
    
        public static Normative? LookupNormative(MTConnectModel model, string id)
            => model.NormativeReferences.FirstOrDefault(o => o.BaseElement == id);
        public static Deprecated? LookupDeprecated(MTConnectModel model, string id)
            => model.DeprecatedReferences.FirstOrDefault(o => o.BaseElement == id);

        public static UmlDataType? LookupDataType(MTConnectModel model, UmlProperty property)
        {
            var dataTypes = model?.AllDataTypes;
            return dataTypes
                ?.Where(o => o.Id == property?.PropertyType)
                ?.FirstOrDefault();
        }

        public static Dictionary<string, System.Type> UmlToCsharpDataTypes = new Dictionary<string, System.Type>()
        {
            { "boolean", typeof(bool) },
            { "ID", typeof(string) },
            { "string", typeof(string) },
            { "float", typeof(float) },
            { "datetime", typeof(DateTime) },
            { "integer", typeof(int) },
            { "xlinktype", typeof(string) },
            { "xslang", typeof(string) },
            { "SECOND", typeof(float) },
            { "IDREF", typeof(string) },
            { "xlinkhref", typeof(string) },
            { "MILLIMETER", typeof(float) },
            { "DEGREE", typeof(float) },
            { "x509", typeof(string) },
            { "unit", typeof(float) },
            { "CUBIC_MILLIMETER", typeof(float) },
            { "int32", typeof(int) },
            { "int64", typeof(long) },
            { "version", typeof(string) },
            { "uint32", typeof(uint) },
            { "uint64", typeof(ulong) },
        };
    }
}
