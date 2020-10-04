﻿using System;
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


namespace CSGOBet.Controllers
{
    
    [ApiController]
    public class UserInformationController : ControllerBase
    {
        SteamApiMW steamApi;
        public UserInformationController(SteamApiMW api)
        {
            steamApi = api;
        }
        [Route("api/userInfo/summary")]
        public async Task<PlayerSummaryModel> GetPlayerSummary()
        {
            var e = await steamApi.GetInterface<SteamUser>().GetPlayerSummaryAsync(HttpContext.GetSteamId());
            return e.Data;
        }
    }
}
