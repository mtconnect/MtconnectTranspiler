using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using System;
using System.ComponentModel;
using System.Net.Http;

namespace MtconnectTranspiler.XmiOptions
{
    /// <summary>
    /// Options for constructing an instance of <see cref="TranspilerDispatcher"/> by retrieving the <see cref="XmiDeserializer"/> using the <see cref="GitHubRelease"/> as a reference to the Release on GitHub to fetch the <c>.xmi</c> of the MTConnect Standard SysML model.
    /// </summary>
    public class FromGitHubOptions : TranspilerDispatcherOptions
    {
        /// <summary>
        /// Reference to the GitHub Release Tag for the version of the MTConnect Standard SysML model to download from GitHub.<br/>
        /// **NOTE**: If you specify <c>latest</c>, the <c>.xmi</c> will be retrieved from the latest Release on GitHub.
        /// </summary>
        public string GitHubRelease { get; set; } = "latest";

        /// <inheritdoc />
        public override XmiDeserializer GetDeserializer(ILogger<XmiDeserializer> logger = null)
        {
            if (string.IsNullOrEmpty(GitHubRelease))
                throw new ArgumentNullException();

            var gitUrl = MTConnectHelper.BuildModelGitHubUri(GitHubRelease);

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(gitUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string xml = response.Content.ReadAsStringAsync().Result;

                    var deserializer = XmiDeserializer.FromXml(xml, logger);
                    return deserializer;
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
        }
    }
}
