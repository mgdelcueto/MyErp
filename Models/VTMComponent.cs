using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTMComponent
    {
        public int CoCoId { get; set; }
        public int CoRefId { get; set; }
        public string CoRefRe { get; set; }
        public string CoRefDes { get; set; }
        public int CoComId { get; set; }
        public string CoComRe { get; set; }
        public string CoComDes { get; set; }
        public double CoRefQt { get; set; }
        public double CoComQt { get; set; }
        public string CoRefUM { get; set; }
        public string CoComUM { get; set; }
    }
}
