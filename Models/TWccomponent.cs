using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TWccomponent
    {
        public int WcoId { get; set; }
        public int? WcoWcid { get; set; }

        [Display(Name = "My Creation Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcoCrDate { get; set; }

        [Display(Name = "My Status Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcoStDate { get; set; }

        [Required,StringLength(125)]
        public string WcoStatus { get; set; }

        [Required,StringLength(125)]
        public string WcoDescr { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim1 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim2 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Dimension (>0)")]
        public double? WcoDim3 { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Weight (>0)")]
        public double? WcoWeight { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Consum Kwh (>0)")]
        public double? WcoConsumW { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? WcoCostMin { get; set; }

        [Required,StringLength(225)]
        public string WcoAcct { get; set; }

        [Required,StringLength(125)]
        public string WcoType { get; set; }

        [Required,StringLength(25)]
        public string WcoCode { get; set; }
    }
}
