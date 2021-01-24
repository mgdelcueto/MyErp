using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TMLocation
    {
        public int MLocId { get; set; }
        public int? MLocLodId { get; set; }
        public int? MLocMatId { get; set; }
        public double? MLocStock { get; set; }
    }
}
