using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TLocation
    {
        public int LocId { get; set; }
        public int? LocFaId { get; set; }
        public DateTime? LocCrDate { get; set; }
        public string LocStatus { get; set; }
        public DateTime? LocStDate { get; set; }
        public string LocCode { get; set; }
        public string LocDescr { get; set; }
        public string LocType { get; set; }
        public double? LocSupm2 { get; set; }
        public string LocAcct { get; set; }
        public double? LocCost { get; set; }
    }
}
