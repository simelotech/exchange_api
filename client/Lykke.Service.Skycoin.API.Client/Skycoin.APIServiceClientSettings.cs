using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.API.Client 
{
    /// <summary>
    /// Skycoin.API client settings.
    /// </summary>
    public class Skycoin.APIServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
