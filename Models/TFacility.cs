using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TFacility
    {
        public int FaId { get; set; }

        [Required,StringLength(125)]
        public string FaDescr { get; set; }

        [Display(Name = "My Creation Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? FaCrDate { get; set; }

        [Required,StringLength(225)]
        public string FaCode { get; set; }

        [Required,StringLength(225)]
        public string FaAcct { get; set; }

        [Required,StringLength(25)]
        public string FaType { get; set; }

        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Value (>0 )")]
        public double? FaSupm2 { get; set; }

        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Cost (>0 )")]
        public double? FaCostMin { get; set; }

        [Required,StringLength(25)]
        public string FaStatus { get; set; }

        [Display(Name = "My Status Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? FaStDate { get; set; }
    }
}
