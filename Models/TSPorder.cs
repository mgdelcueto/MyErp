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
        [Display(Name="SPODate")]
        public DateTime? Spodate { get; set; }

        [Required]
        [Display(Name="Status")]
        public string Spostatus { get; set; }

         [Required,Range(0, int.MaxValue, ErrorMessage = "Enter External Reference")]
        [Display(Name="RefEx")]
        public int? SporeferEx  { get; set; }

        [Display(Name="Product")]
        public int? SpocprodId  { get; set; }

        [Required,StringLength(125)]
        [Display(Name="SPOrder")]
        public string Spopo { get; set; }

        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Proce (>0)")]
        [Display(Name="Price")]
        public double? Spoprice { get; set; }

        [Required]
        [Display(Name="Currency")]
        public string Spocurcy { get; set; }

        [Required,DataType(DataType.Date)]         
        [Display(Name="SPODateSt")]
        public DateTime? SpoDateSt { get; set; }

        [Required,Range(0,1,ErrorMessage="Enter Valid proportion between 0 and 1")]
        [Display(Name="SPOPcRep")]
        public double? SpoPcRep { get; set; }

        [Required]
        [Display(Name="Incoterm")]
        public string Spoincoterm { get; set; }

        [Required]
        [Display(Name="Delay")]
        public int? Spodelay { get; set; }

        [Required]
        [Display(Name="DelayUnit")]
        public string Spodelayunit { get; set; }
    }
}