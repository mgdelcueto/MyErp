using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TMPorder
    {
        public int Poid { get; set; }

        [Display(Name = "Date From")]
        [Required,DataType(DataType.Date)]         
        public DateTime PodateFrom { get; set; }

        [Display(Name = "Date to")]
        [Required,DataType(DataType.Date)]         
        public DateTime PodateTo { get; set; }

        [Display(Name = "Status")]
        [Required,StringLength(25)]
        public string Potype { get; set; }

        [Display(Name = "Material")]
        public int PomatId { get; set; }

        [Display(Name = "Suplier")]
        public int PosupId { get; set; }

        [Display(Name = "Quantity")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Quantity (>0)")]
        public double Poqty { get; set; }

        [Display(Name = "Cummulated")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Cummulated (>0)")]
        public double? PocumQty { get; set; }

        [Display(Name = "Status")]
        [StringLength(125)]
        public string Postat { get; set; }

        [Display(Name = "Status Date")]
        [DataType(DataType.Date)]         
        public DateTime PostDate { get; set; }
    }
}
