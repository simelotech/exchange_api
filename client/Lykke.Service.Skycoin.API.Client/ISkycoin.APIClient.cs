using JetBrains.Annotations;

namespace Lykke.Service.Skycoin.API.Client
{
    /// <summary>
    /// Skycoin.API client interface.
    /// </summary>
    [PublicAPI]
    public interface ISkycoin.APIClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - ISkycoin.APIApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        ISkycoin.APIApi Api { get; }
    }
}
