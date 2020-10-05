using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSGOBet.Middlewares;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Steam.Models.SteamCommunity;
using SteamWebAPI2;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;
using CSGOBet.Extensions;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CSGOBet.Controllers
{
    
    [ApiController]
    public class UserInformationController : ControllerBase
    {
        SteamApiService steamApi;
        public UserInformationController(SteamApiService api)
        {
            steamApi = api;
        }
        [Route("authApi/userInfo/summary")]
        public async Task<PlayerSummaryModel> GetPlayerSummary()
        {
            var steamId = HttpContext.GetSteamId();
            var e = await steamApi.GetInterface<SteamUser>().GetPlayerSummaryAsync((ulong)steamId);
            return e.Data;
        }
        [Route("authApi/api/userInfo/getInventory")]
        public async Task<string> GetUserInventory()
        {
            var steamId = HttpContext.GetSteamId();
            string inventory = await new WebClient().DownloadStringTaskAsync(
                new Uri($"https://steamcommunity.com/profiles/{steamId}/inventory/json/730/2"));
            return JObject.Parse(inventory)["rgInventory"].ToString();
        }
    }
}
