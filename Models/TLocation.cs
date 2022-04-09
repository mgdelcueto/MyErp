using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TLocation
    {
        public int LocId { get; set; }

        [Display(Name="LocFaId")]
        [Required,Range(1,Double.MaxValue,ErrorMessage="mLocFaId")]
        public int? LocFaId { get; set; }

        [Display(Name="LocCrDate")]
        [Required(ErrorMessage="mLocCrDate"),DataType(DataType.Date)]          
        public DateTime? LocCrDate { get; set; }

        [Display(Name="LocStatus")]
        [Required(ErrorMessage="mLocStatus"),StringLength(125)]
        public string LocStatus { get; set; }

        [Display(Name="LocStDate")]
        [Required(ErrorMessage="mLocStDate"),DataType(DataType.Date)]          
        public DateTime? LocStDate { get; set; }

        [Display(Name="LocCode")]
        [Required(ErrorMessage="mLocCode"),StringLength(125)]
        public string LocCode { get; set; }

        [Display(Name="LocDescr")]
        [Required(ErrorMessage="mLocDescr"),StringLength(225)]
        public string LocDescr { get; set; }

        [Display(Name="LocType")]
        [Required(ErrorMessage="mLocType"),StringLength(25)]
        public string LocType { get; set; }

        [Display(Name = "LocSupm2")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Value (>0 )")]
        public double? LocSupm2 { get; set; }

        [Display(Name="LocAcct")]
        [Required(ErrorMessage="mLocAcct"),StringLength(225)]
        public string LocAcct { get; set; }
      
        [Display(Name = "LocCost")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Cost (>0 )")]
        public double? LocCost { get; set; }
    }
}
