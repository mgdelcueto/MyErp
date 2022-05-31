using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TInputBLH
    {
        public int InBLId { get; set; }

        [Display(Name="InBLnum")]
        [Required(ErrorMessage="mReq"),StringLength(50)]
        public string InBLnum { get; set; }

        [Display(Name="InBLSupId")]
        [Required,Range(1, int.MaxValue, ErrorMessage = "mReq")]
        public int? InBLSupId { get; set; }

        [Display(Name="InBLDateRec")]
        [Required(ErrorMessage="mReq"),DataType(DataType.Date)]         
        public DateTime? InBLDateRec { get; set; }

        [Display(Name="InBLStatus")]
        [Required(ErrorMessage="mReq"),StringLength(50)]
        public string InBLStatus { get; set; }

        [Display(Name="InBLObser")]
        [StringLength(250)]
        public string  InBLObser { get; set; }

        [Display(Name="InBLDateStat")]
        [DataType(DataType.Date)]         
        public DateTime? InBLDateStat { get; set; }

    }
}
