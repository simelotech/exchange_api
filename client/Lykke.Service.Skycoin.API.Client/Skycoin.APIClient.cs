using Lykke.HttpClientGenerator;

namespace Lykke.Service.Skycoin.API.Client
{
    /// <summary>
    /// Skycoin.API API aggregating interface.
    /// </summary>
    public class Skycoin.APIClient : ISkycoin.APIClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to Skycoin.API Api.</summary>
        public ISkycoin.APIApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public Skycoin.APIClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<ISkycoin.APIApi>();
        }
    }
}
