﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExpMater
    {
        public int? ExpComp { get; set; }
        public double? TComQty { get; set; }
        public string MatRefer { get; set; }
        public string MatDescr { get; set; }
        public string MatUnMed { get; set; }
        public double? TCom { get; set; }
    }
}
