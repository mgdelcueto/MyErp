using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TWccomponent
    {
        [Display(Name = "WcoId")]
        public int WcoId { get; set; }

        [Display(Name = "WcoWcid")]
        public int? WcoWcid { get; set; }

        [Display(Name = "WcoCrDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcoCrDate { get; set; }

        [Display(Name = "WcoStDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcoStDate { get; set; }

        [Display(Name = "WcoStatus")]
        [Required,StringLength(125)]
        public string WcoStatus { get; set; }

        [Display(Name = "WcoDescr")]
        [Required,StringLength(125)]
        public string WcoDescr { get; set; }

        [Display(Name = "WcoDim1")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim1 { get; set; }

        [Display(Name = "WcoDim2")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim2 { get; set; }

        [Display(Name = "WcoDim3")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim3 { get; set; }

        [Display(Name = "WcoWeight")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Weight (>0)")]
        public double? WcoWeight { get; set; }

        [Display(Name = "WcoConsumW")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Consum Kwh (>0)")]
        public double? WcoConsumW { get; set; }

        [Display(Name = "WcoCostMin")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? WcoCostMin { get; set; }

        [Display(Name = "WcoAcct")]
        [Required,StringLength(225)]
        public string WcoAcct { get; set; }

        [Display(Name = "WcoType")]
        [Required,StringLength(125)]
        public string WcoType { get; set; }

        [Display(Name = "WcoCode")]
        [Required,StringLength(25)]
        public string WcoCode { get; set; }
    }
}
