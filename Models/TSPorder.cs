using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TSPorder
    {
        public int Spoid { get; set; }
        public int? SposupId { get; set; }

        [Required,DataType(DataType.Date)]         
        public DateTime? Spodate { get; set; }

        [Required,StringLength(25)]
        [Display(Name="Status")]
        public string Spostatus { get; set; }

        [Required,StringLength(125)]
        [Display(Name="Reference Ext")]
        public string SporeferEx { get; set; }

        [Required,StringLength(225)]
        [Display(Name="Description Ext")]
        public string SpodescEx { get; set; }

        [Display(Name="Product")]
        public int? SpocprodId { get; set; }

        [Required,StringLength(125)]
        [Display(Name="Purchase Order")]
        public string Spopo { get; set; }

        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Proce (>0)")]
        [Display(Name="Prioce")]
        public double? Spoprice { get; set; }
        [Required]
        [Display(Name="Currency")]
        public string Spocurcy { get; set; }
    }
}
