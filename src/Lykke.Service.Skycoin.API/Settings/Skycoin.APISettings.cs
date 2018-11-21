using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Skycoin.API.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class Skycoin.APISettings
    {
        public DbSettings Db { get; set; }
    }
}
