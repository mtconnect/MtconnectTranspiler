using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;
using System.ComponentModel;
using System.Net.Http;

namespace MtconnectTranspiler.XmiOptions
{
    /// <summary>
    /// Options for constructing an instance of <see cref="TranspilerDispatcher"/> by retrieving the <see cref="XmiDeserializer"/> using the latest XML hosted on the MTConnect Model Browser site.
    /// </summary>
    public class FromMtconnectOrg : TranspilerDispatcherOptions
    {
        /// <inheritdoc />
        public override XmiDeserializer GetDeserializer(ILogger<XmiDeserializer> logger = null)
        {
            var mtconnectOrgUrl = "https://model.mtconnect.org/MTConnectSysMLModel.xml";

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(mtconnectOrgUrl).Result;
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
