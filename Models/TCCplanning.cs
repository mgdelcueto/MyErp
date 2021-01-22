using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCCplanning
    {
        public int CplanId { get; set; }

        [Display(Name = "My Plant")]
        public int? CplanCplantId { get; set; }
        public int? CplanCustId { get; set; }

        [Display(Name = "My Product")]
        public int? CplanCprodId { get; set; }

        [Display(Name = "My Date From")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateFrom { get; set; }

        [Display(Name = "My Date To")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateTo { get; set; }

        [Display(Name = "My Quantity to send")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Quantity (>0 )")]
        public double? CplanQty { get; set; }

        [Display(Name = "My Firm Status")]
        [Required,StringLength(55)]
        public string CplanFirmSt { get; set; }
    }
}
