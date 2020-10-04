using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SteamWebAPI2;
using SteamWebAPI2.Utilities;

namespace CSGOBet.Middlewares
{
    public class SteamApiMW
    {
        SteamWebInterfaceFactory steamFactory;
        public SteamApiMW() => steamFactory = new SteamWebInterfaceFactory("992F1F9C80462DF0620A03FB1199C6A6");
        public T GetInterface<T>()
        {
            return steamFactory.CreateSteamWebInterface<T>(new HttpClient());
        }
    }
}
