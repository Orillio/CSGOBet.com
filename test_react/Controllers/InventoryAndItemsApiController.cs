using CSGOBet.Middlewares;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Steam.Models.SteamEconomy;
using SteamWebAPI2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOBet.Controllers
{
    [ApiController]
    public class InventoryAndItemsApiController : ControllerBase
    {
        SteamApiService steamApi;
        public InventoryAndItemsApiController(SteamApiService api)
        {
            steamApi = api;
        }
        [Route("authApi/itemsService/getItemInfoByClassId")]
        public async Task<AssetClassInfoResultModel> GetInventoryItemInfo(ulong classId)
        {
            var info = await steamApi.GetInterface<SteamEconomy>()
                .GetAssetClassInfoAsync(730, new List<ulong> { classId }, language: "ru");
            return info.Data;
        }
        [Route("authApi/itemsService/getItemInfoByClassId/multiple")]
        public async Task<AssetClassInfoResultModel> GetInventoryItemInfo(string data)
        {
            var jobject = JObject.Parse(data);
            var children = jobject.Children().Children().Children();
            var info = await steamApi.GetInterface<SteamEconomy>()
                .GetAssetClassInfoAsync(730, new List<ulong>(children.Select(o => o.Value<ulong>())), language: "ru");
            return info.Data;
        }
    }
}
