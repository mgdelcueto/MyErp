using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTBLDet
    {
        public int InBLDId { get; set; }

        [Display(Name="InBLId")]
        [Required,Range(0, int.MaxValue, ErrorMessage = "mReq")]
        public int? InBLId { get; set; }

        [Display(Name="InBLDProdId")]
        [Required,Range(0, int.MaxValue, ErrorMessage = "mReq")]
        public int? InBLDProdId { get; set; }

        [Display(Name="InBLDMRefer")]
        [Required(ErrorMessage="mReq"),StringLength(125)]
        public string InBLDMRefer { get; set; }

        [Display(Name="InBLDMDescr")]
        [Required(ErrorMessage="mReq"),StringLength(225)]
        public string InBLDMDescr { get; set; }

        [Display(Name="InBLDMatUnMed")]
        [Required(ErrorMessage="mReq"),StringLength(25)]
        public string InBLDMatUnMed { get; set; }

        [Display(Name="InBLDQty")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "mReq")]
        public double InBLDQty { get; set; }

        [Display(Name="InBLDUM")]
        [Required,Range(0, int.MaxValue, ErrorMessage = "mReq")]
        public int? InBLDUM { get; set; }

        [Display(Name="InBLDUMRef")]
        [StringLength(50)]
        public string? InBLDUMRef { get; set; }

        [Display(Name="InBLDStat")]
        [Required(ErrorMessage="mReq"),StringLength(50)]
        public string InBLDStat { get; set; }


    }
}
