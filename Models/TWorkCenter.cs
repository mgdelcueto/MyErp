using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TWorkCenter
    {
        [Display(Name = "WcdId")]
        public int WcdId { get; set; }

        [Display(Name = "WcfaId")]
        public int? WcfaId { get; set; }

        [Display(Name = "WccrDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WccrDate { get; set; }

        [Display(Name = "Wcstatus")]
        [Required,StringLength(125)]
        public string Wcstatus { get; set; }

        [Display(Name = "WcstDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcstDate { get; set; }

        [Display(Name = "Wccode")]
        [Required,StringLength(125)]
        public string Wccode { get; set; }

        [Display(Name = "Wcdescr")]
        [Required,StringLength(125)]
        public string Wcdescr { get; set; }

        [Display(Name = "Wctype")]
        [Required,StringLength(25)]
        public string Wctype { get; set; }

        [Display(Name = "Wcsupm2")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Surface M2 (>0)")]
        public double? Wcsupm2 { get; set; }

        [Display(Name = "Wcacct")]
        [Required,StringLength(225)]
        public string Wcacct { get; set; }

        [Display(Name = "WccostMin")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? WccostMin { get; set; }
    }
}
