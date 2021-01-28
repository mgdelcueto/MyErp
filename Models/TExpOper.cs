using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExpOper
    {
        public double? OperTime { get; set; }
        public int? RouWcId { get; set; }
        public string Wccode { get; set; }
        public string Wcdescr { get; set; }
    }
}
