using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TMRouting
    {
        public int RouId { get; set; }
        public int RouRefId { get; set; }
        public int RouWcid { get; set; }
        public string RouFase { get; set; }
        public string RouOper { get; set; }
        public double RouWunit { get; set; }
        public double RouWtime { get; set; }
        public string RouTunit { get; set; }
    }
}
