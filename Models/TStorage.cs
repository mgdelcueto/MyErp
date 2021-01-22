using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TStorage
    {
        public int StorId { get; set; }

        [Required,StringLength(155)]
        public string StorCode { get; set; }

        [Display(Name="Facility")]
        public int? StorFac { get; set; }

        [Display(Name="Description")]
        [Required,StringLength(255)]
        public string StorDescr { get; set; }

        [Display(Name="Satatus")]
        [Required,StringLength(125)]
        public string StorStatus { get; set; }

        [Display(Name="Status Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? StorStDate { get; set; }

        [Display(Name="Dimension 1")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid dimension (>0)")]
        public double? StorDim1 { get; set; }

        [Display(Name="Dimension 2")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid dimension (>0)")]
        public double? StorDim2 { get; set; }

        [Display(Name="Dimension 3")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid dimension (>0)")]
        public double? StorDim3 { get; set; }

        [Display(Name="Area m2")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid dimension (>0)")]
        public double? Storm2 { get; set; }
    }
}
