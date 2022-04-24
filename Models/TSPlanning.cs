using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TSPlanning
    {
        public int PlanId { get; set; }
        public int? PlanSupId { get; set; }
        public int? PlanProdId { get; set; }

        [Required,DataType(DataType.Date)]         
        [Display(Name="DateFrom")]         
        public DateTime? PlanDateFrom { get; set; }

        [Required,DataType(DataType.Date)]         
        [Display(Name="DateTo")]         
        public DateTime? PlanDateTo { get; set; }

        [Display(Name = "SendQty")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Quantity (>0)")]
        public double? PlanQty { get; set; }

        [Display(Name = "PlanFirm")]
        [StringLength(55)]
        public string PlanFirmSt { get; set; }
    }
    public partial class TSPlanningV
    {
        public int PlanId { get; set; }
        public int? PlanSupId { get; set; }
        public int? PlanProdId { get; set; }
        [DataType(DataType.Date)]         
        [Display(Name="My Date From:")]         
        public DateTime? PlanDateFrom { get; set; }

        [DataType(DataType.Date)]         
        [Display(Name="My Date To:")]         
        public DateTime? PlanDateTo { get; set; }

        [Display(Name = "My Quantity")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Quantity (>0)")]
        public double? PlanQty { get; set; }

        [Display(Name = "My Status (Firm)")]
        [StringLength(55)]
        public string PlanFirmSt { get; set; }
        
        
        public int ProdId { get; set; }
        public int? ProdSupId { get; set; }

        [DataType(DataType.Date)]         
        [Display(Name="My Creation Date")]         
        public DateTime? ProdCrDate { get; set; }

        [Display(Name = "My Product Status")]
        [StringLength(125)]
        public string ProdStatus { get; set; }

        [DataType(DataType.Date)]         
        [Display(Name="My Status Date")]         
        public DateTime? ProdStDate { get; set; }

        [Display(Name = "My Product Reference")]
        [StringLength(125)]
        public string ProdRefer { get; set; }

        [Display(Name = "My Product Reference")]
        [StringLength(125)]
        public string ProdDescr { get; set; }

    }

}
