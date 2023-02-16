using MtconnectTranspiler.Contracts;
using System;
using System.ComponentModel;
using System.Net.Http;

namespace MtconnectTranspiler
{
    /// <summary>
    /// Options for constructing an instance of <see cref="TranspilerDispatcher"/> by retrieving the <see cref="XmiDeserializer"/> using the <see cref="FromGitHubOptions.GitHubRelease"/> as a reference to the Release on GitHub to fetch the <c>.xmi</c> of the MTConnect Standard SysML model.
    /// </summary>
    public class FromGitHubOptions : TranspilerDispatcherOptions
    {
        /// <summary>
        /// Reference to the GitHub Release Tag for the version of the MTConnect Standard SysML model to download from GitHub.<br/>
        /// **NOTE**: If you specify <c>latest</c>, the <c>.xmi</c> will be retrieved from the latest Release on GitHub.
        /// </summary>
        public string GitHubRelease { get; set; } = "latest";

        /// <inheritdoc />
        internal override XmiDeserializer GetDeserializer()
        {
            if (string.IsNullOrEmpty(GitHubRelease)) throw new ArgumentNullException();

            var gitUrl = MTConnectHelper.BuildModelUri(GitHubRelease);

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(gitUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string xml = response.Content.ReadAsStringAsync().Result;

                    var deserializer = XmiDeserializer.FromXml(xml);
                    return deserializer;
                } else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
        }
    }
}
