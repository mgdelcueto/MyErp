using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TMPoprice
    {
        public int PrId { get; set; }

        [Display(Name = "Purchase Order")]
        [Required,Range(0, int.MaxValue, ErrorMessage = "Enter valid PO")]
        public int PrPoid { get; set; }

        [Display(Name = "Date from")]
        [Required,DataType(DataType.Date)]         
        public DateTime PrDateFrom { get; set; }

        [Display(Name = "Date to")]
        [Required,DataType(DataType.Date)]         
        public DateTime? PrDateTo { get; set; }

        [Display(Name = "Price")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double PrPrice { get; set; }

        [Display(Name = "Currency")]
        [Required,StringLength(25)]
        public string PrCurcy { get; set; }
    }
}
