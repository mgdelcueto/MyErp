using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCScShop
    {
        public int ShopId { get; set; }
        public DateTime? ShopFrom { get; set; }
        public DateTime? ShopTo { get; set; }
        public int? ShopWctr { get; set; }
        public int? ShopCprodId { get; set; }
        public int? ShopDest { get; set; }
        public DateTime? ShopDate { get; set; }
        public int? ShopTruckId { get; set; }
        public double? ShopQty { get; set; }
        public double? ShopMinLot { get; set; }
        public double? ShopUemb { get; set; }
        public double? ShopConts { get; set; }
        public int? ShopSchedId { get; set; }
        public int? ShopVersion { get; set; }
        public string ShopComent { get; set; }
        public string ShopFg { get; set; }
        public double? ShopTunit { get; set; }
        public double? ShopaTunit { get; set; }
        public string Shopuser {get; set; }
        public string Roufase {get; set; }
    }
}
