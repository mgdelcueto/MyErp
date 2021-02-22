using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCTruck
    {
        public int TruckId { get; set; }
        public int? TruckCustId { get; set; }
        public int? TruckPlantId { get; set; }
        public DateTime? TruckCrDate { get; set; }
        public string TruckCode { get; set; }
        public string TruckDeno { get; set; }
    }
}
