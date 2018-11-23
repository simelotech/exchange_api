using Lykke.HttpClientGenerator;

namespace Lykke.Service.Skycoin.API.Client
{
    /// <summary>
    /// Skycoin.API API aggregating interface.
    /// </summary>
    public class SkycoinAPIClient : ISkycoinAPIClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to Skycoin.API Api.</summary>
        public ISkycoinAPIApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public SkycoinAPIClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<ISkycoinAPIApi>();
        }
    }
}
