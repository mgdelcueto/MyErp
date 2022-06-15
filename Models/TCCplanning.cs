using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCCplanning
    {
        public int CplanId { get; set; }

        [Display(Name = "Plant")]
        public int? CplanCplantId { get; set; }
        public int? CplanCustId { get; set; }

        [Display(Name = "RefInt")]
        [Required(ErrorMessage="Product is required"),Range(1,int.MaxValue,ErrorMessage="Product is reuqired")]
        public int? CplanCprodId { get; set; }
        public int? CplanCmatId { get; set; }

        [Display(Name = "DateFrom")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateFrom { get; set; }

        [Display(Name = "DateTo")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateTo { get; set; }

        [Display(Name = "SendQty")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Quantity (>0 )")]
        public double? CplanQty { get; set; }

        [Display(Name = "FirmStat")]
        [Required,StringLength(55)]
        public string CplanFirmSt { get; set; }

        [Display(Name = "UnitContainer")]
        [Required,Range(0, Int16.MaxValue, ErrorMessage = "Enter valid Quantity (>0 )")]
        public int? CplanUemb { get; set; }

        [Display(Name = "Truck")]
        public int? CplanTruckId { get; set; }

    }
}
