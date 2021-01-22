using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TWorkCenter
    {
        public int WcdId { get; set; }
        public int? WcfaId { get; set; }

        [Display(Name = "My Creation Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WccrDate { get; set; }

        [Required,StringLength(125)]
        public string Wcstatus { get; set; }

        [Display(Name = "My Status Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? WcstDate { get; set; }

        [Required,StringLength(125)]
        public string Wccode { get; set; }

        [Required,StringLength(125)]
        public string Wcdescr { get; set; }

        [Required,StringLength(25)]
        public string Wctype { get; set; }

        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Surface M2 (>0)")]
        public double? Wcsupm2 { get; set; }

        [Required,StringLength(225)]
        public string Wcacct { get; set; }

        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid Cost (>0)")]
        public double? WccostMin { get; set; }
    }
}
