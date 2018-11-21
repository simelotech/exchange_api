using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.Skycoin.API.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public Skycoin.APISettings Skycoin.APIService { get; set; }
    }
}
