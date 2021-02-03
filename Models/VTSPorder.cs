using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VTSPorder
    {
        public int Spoid { get; set; }
        public int? SposupId { get; set; }


        [Display(Name = "My Refer Ext")]
        [Required,StringLength(125)]
        public string SporeferEx { get; set; }

        [Display(Name = "My Description Ex")]
        [Required,StringLength(225)]
        public string SpodescEx { get; set; }
        [Display(Name = "My Refer Int")]
        [Required,StringLength(125)]
        public string SprodRefInt { get; set; }

        [Display(Name = "My Description Int")]
        [Required,StringLength(225)]
        public string SprodDescInt { get; set; }
        public int? SpocprodId { get; set; }

        [Display(Name = "My PO")]
        [Required,StringLength(125)]
        public string Spopo { get; set; }

        [Display(Name = "My Price")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Price (>0 )")]
        public double? Spoprice { get; set; }

        [Display(Name = "My Currency")]
        [Required,StringLength(25)]
        public string Spocurcy { get; set; }
    }
}
