using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTMLocation
    {
        public int? LoLoId { get; set; }
        public string LoLocCode { get; set; }
        public string LoLocDescr { get; set; }
        public int LoRefId { get; set; }
        public string LoRefRe { get; set; }
        public string LoRefDes { get; set; }
        public double? LoRefSt { get; set; }
        public string LoRefUM { get; set; }
    }
}
