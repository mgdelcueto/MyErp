using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTMRouting
    {
        public int RoRoId { get; set; }

        [Display(Name = "Work Center")]
        [Required, Range(1,int.MaxValue,ErrorMessage="Enter a Valid Work Center")]
        public int RoRoWCId { get; set; }

        [Display(Name = "Work Center")]
        [StringLength(225)]
        public string RoRoWCDe { get; set; }
        public int RoRoMatId { get; set; }

        [Display(Name = "Reference")]
        [StringLength(125)]
        public string RoRoMatRe { get; set; }

        [Display(Name = "Description")]
        [StringLength(125)]
        public string RoRoMatDe { get; set; }

        [Display(Name = "Fase")]
        [Required,StringLength(25)]
        public string RoRoFase { get; set; }

        [Display(Name = "Operation")]
        [Required,StringLength(225)]
        public string RoRoOper { get; set; }

        [Display(Name = "Parts produced")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid number (>0)")]
        public double RoRoWunit { get; set; }

        [Display(Name = "Time to produce")]
        [Required,Range(0, double.MaxValue, ErrorMessage = "Enter valid number (>0)")]
        public double RoRoWtime { get; set; }

        [Display(Name = "Unit of time")]
        [Required,StringLength(25)]
        public string RoRoTunit { get; set; }
    }
}
