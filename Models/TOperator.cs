using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TOperator
    {
        public int OpeId { get; set; }

        [Display(Name = "OperCode")]
        [Required,StringLength(25)]
        public string OpeCode { get; set; }

        [Display(Name = "OperDescr")]
        [Required,StringLength(225)]
        public string OpeDesc { get; set; }

        [Display(Name = "Account")]
        [Required,StringLength(125)]
        public string OpeAcct { get; set; }

        [Display(Name = "Costh")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? OpeCosth { get; set; }

        [Display(Name = "Curcy")]
        [Required,StringLength(25)]
        public string OpeCurcy { get; set; }
    }
}
