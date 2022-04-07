using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TFacility
    {
        public int FaId { get; set; }

        [Display(Name = "FDescr")]
        [Required,StringLength(125)]
        public string FaDescr { get; set; }

        [Display(Name = "FCrDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? FaCrDate { get; set; }

        [Display(Name = "FCode")]
        [Required,StringLength(225)]
        public string FaCode { get; set; }

        [Display(Name = "FAcct")]
        [Required,StringLength(225)]
        public string FaAcct { get; set; }

        [Display(Name = "FType")]
        [Required,StringLength(25)]
        public string FaType { get; set; }

        [Display(Name = "FSuperf")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Value (>0 )")]
        public double? FaSupm2 { get; set; }

        [Display(Name = "FCostMin")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Cost (>0 )")]
        public double? FaCostMin { get; set; }

        [Display(Name = "FStatus")]
        [Required,StringLength(25)]
        public string FaStatus { get; set; }

        [Display(Name = "FStDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? FaStDate { get; set; }
    }
}
