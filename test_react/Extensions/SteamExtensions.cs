using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOBet.Extensions
{
    public static class SteamExtensions
    {
        public static ulong? GetSteamId(this HttpContext context)
        {
            if (!context.User.Identity.IsAuthenticated) return null;
            return ulong.Parse(context.User.Claims.ToList()[0].Value.Split("/")[5]);

        }
    }
}