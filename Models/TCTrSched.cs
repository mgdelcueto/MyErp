using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCTrSched
    {
        public int TrScId { get; set; }
        public int? TrScTruckId { get; set; }
        public int? TrScDayOfWeek { get; set; }
        public DateTime? TrScCrLoadStart { get; set; }
        public DateTime? TrScCrDeparture { get; set; }
        public string TrScCode { get; set; }
        public string TrScDeno { get; set; }
    }
}
