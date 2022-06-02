using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VTCPorder
    {
        public int Cpoid { get; set; }
        public int? CpocustId { get; set; }


        [Display(Name = "My Refer Ext")]
        [Required,StringLength(125)]
        public string CporeferEx { get; set; }

        [Display(Name = "My Description Ex")]
        [Required,StringLength(225)]
        public string CpodescEx { get; set; }
        [Display(Name = "My Refer Int")]
        [Required,StringLength(125)]
        public string CprodRefInt { get; set; }

        [Display(Name = "My Description Int")]
        [Required,StringLength(225)]
        public string CprodDescInt { get; set; }
        public int? CpocprodId { get; set; }

        [Display(Name = "My PO")]
        [Required,StringLength(125)]
        public string Cpopo { get; set; }

        [Display(Name = "My Price")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Price (>0 )")]
        public double? Cpoprice { get; set; }

        [Display(Name = "My Currency")]
        [Required,StringLength(25)]
        public string Cpocurcy { get; set; }

        [Display(Name = "My Status")]
        [Required,StringLength(25)]
        public string Cpostatus { get; set; }
    }
}
