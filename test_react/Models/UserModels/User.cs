using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOBet.Models.UserModels
{
    public class User
    {
        public int SteamId { get; set; }
        public List<ulong> InventoryItemIds { get; set; }
        public uint Balance { get; set; }
        public string TradeOfferUrl { get; set; }
    }
}
