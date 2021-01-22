using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VTCCplanning
    {
        public int CplanId { get; set; }
        public int? CplanCplantId { get; set; }
        public int? CplanCustId { get; set; }
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
        
        [Display(Name = "My Refer Int")]
        [Required,StringLength(125)]
        public string CprodRefInt { get; set; }

        [Display(Name = "My Description")]
        [Required,StringLength(255)]
        public string CprodDescInt { get; set; }

    }
}
