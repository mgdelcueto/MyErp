using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTWOperator
    {

        [Display(Name = "WorkCenter")]
        [Required]
        public int? OpWcId {get;set;}

        [Display(Name = "Op0erator")]
        [Required]
        public int? OpOpId { get; set; }

        [Display(Name = "Operator Code")]
        [StringLength(25)]
        public string OpOpCode { get; set; }

        [Display(Name = "Operator Decsription")]
        [StringLength(225)]
        public string OpOpDes { get; set; }

        [Display(Name = "Account")]
        [StringLength(125)]
        public string OpOPAcct { get; set; }

        [Display(Name = "Operator Cost")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? OpOpCost { get; set; }

        [Display(Name = "Currency")]
        [StringLength(25)]
        public string OpOPCurcy { get; set; }

        [Display(Name = "Operator Code")]
        [StringLength(25)]
        public string OpWcCode { get; set; }

        [Display(Name = "Operator Decsription")]
        [StringLength(225)]
        public string OpWcDes { get; set; }

    }
}
