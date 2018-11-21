using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.API.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
