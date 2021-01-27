using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TWcoperator
    {
        public int WcopId { get; set; }
        public int? WcopWcid { get; set; }
        public int? WcopOpId { get; set; }
        public double? WcopNum { get; set; }
    }
}
