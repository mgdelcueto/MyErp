using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCSched
    {
        public int ScId { get; set; }
        public DateTime? ScFrom { get; set; }
        public DateTime? ScTo { get; set; }
        public int? ScCustId { get; set; }
        public int? ScPlantId { get; set; }
        public DateTime? ScDate { get; set; }
        public int? ScTruckId { get; set; }
        public int? ScCprodId { get; set; }
        public double? ScQty { get; set; }
        public double? ScUemb { get; set; }
        public double? ScConts { get; set; }
        public int? ScVersion { get; set; }
        public string ScComent { get; set; }
        public string ScUser { get; set; }
    }
}
