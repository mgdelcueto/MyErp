using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TMStorage
    {
        public int MstorId { get; set; }
        public int? MstorMatId { get; set; }
        public double? MstorStock { get; set; }
    }
}
