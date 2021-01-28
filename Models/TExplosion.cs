using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExplosion
    {
        public int ExpId { get; set; }
        public int ExpOrder { get; set; }
        public int ExpLevel { get; set; }
        public int ExpComp { get; set; }
        public string ExpRefer { get; set; }
        public string ExpDescr { get; set; }
        public string ExpsLevel { get; set; }
        public double ExpCoef { get; set; }
        public double ExpAcCoef { get; set; }
    }
}
