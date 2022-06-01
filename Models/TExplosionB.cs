using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExplosionB
    {
        public int ExpId { get; set; }
        public int ExpComp { get; set; }
        public string ExpsLevel { get; set; }
        public string ExpRefer { get; set; }
        public string ExpDescr { get; set; }
        public double? ExpCoef { get; set; }
        public string ExpUm { get; set; }
        public string ExpRouFase { get; set; }
        public string ExpRouOper { get; set; }
        public double? ExpRouTime { get; set; }
        public string ExpRouTunit { get; set; }
        public string WCCode { get; set; }
    }
}
