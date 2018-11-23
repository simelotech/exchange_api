using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.API.Client 
{
    /// <summary>
    /// Skycoin.API client settings.
    /// </summary>
    public class SkycoinAPIServiceClientSettings
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
