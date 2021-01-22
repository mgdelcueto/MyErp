using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TMaterial
    {
        public int MatId { get; set; }

        [Display(Name="Reference")]
        [Required,StringLength(125)]
        public string MatRefer { get; set; }

        [Display(Name="Type")]
        [Required,StringLength(25)]
        public string MatType { get; set; }

        [Display(Name="Class")]
        [Required,StringLength(25)]
        public string MatClass { get; set; }

        [Display(Name="Status")]
        [Required,StringLength(125)]
        public string MatStatus { get; set; }
        [Display(Name="Status Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? MatStDate { get; set; }

        [Display(Name="Description")]
        [Required,StringLength(225)]
        public string MatDescr { get; set; }

        [Display(Name = "Dimension 1")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? MatDim1 { get; set; }

        [Display(Name = "Dimension 2")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? MatDim2 { get; set; }

        [Display(Name = "Dimension 3")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? MatDim3 { get; set; }

        [Display(Name = "Weight")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? MatWeight { get; set; }

        [Display(Name="Un.Measure")]
        [Required,StringLength(25)]
        public string MatUnMed { get; set; }
    }
}
