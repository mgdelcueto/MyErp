using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TMComponent
    {
        public int CoId { get; set; }
        public int CoRefId { get; set; }
        public int CoComId { get; set; }
        public double CoQtyRe { get; set; }
        public double CoQtyCo { get; set; }
        public string CoStat { get; set; }
        public DateTime? CoStDate { get; set; }
    }
}
