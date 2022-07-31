using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TMRouting
    {
        public int RouId { get; set; }

        [Display(Name = "Refer")]
        public int RouRefId { get; set; }

        [Display(Name = "WCenter")]
        public int RouWcid { get; set; }

        [Display(Name = "Fase")]
        [Required,StringLength(25)]
        public string RouFase { get; set; }

        [Display(Name = "Operation")]
        [Required,StringLength(255)]
        [DataType(DataType.MultilineText)]
        public string RouOper { get; set; }

        [Display(Name = "NumParts")]
        [Required,Range(0.001, double.MaxValue, ErrorMessage = "Enter valid Value (>0)")]
        public double RouWunit { get; set; }

        [Display(Name = "Time")]
        [Required,Range(0.001, double.MaxValue, ErrorMessage = "Enter valid Value (>0)")]
        public double RouWtime { get; set; }

        [Display(Name = "UTime")]
        [Required,StringLength(25)]
        public string RouTunit { get; set; }

        [Display(Name = "MinLot")]
        [Required,Range(0.001, double.MaxValue, ErrorMessage = "Enter valid Value (>0)")]
        public double RouMinLot { get; set; }

        [Display(Name = "UEmba")]
        [Required,Range(0.001, double.MaxValue, ErrorMessage = "Enter valid Value (>0)")]
        public double RouUEmb { get; set; }

  }
}
