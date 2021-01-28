using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExpMater
    {
        public double? TcomQty { get; set; }
        public int? ExpComp { get; set; }
        public string MatRefer { get; set; }
        public string MatDescr { get; set; }
        public string MatUnMed { get; set; }
    }
}
