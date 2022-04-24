using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPPresen
    {
        public int PresId { get; set; }
        public int? PresPerId { get; set; }

       [Display(Name="Location")]
       [Required,StringLength(10)]
        public string PresLocal { get; set; }

       [Display(Name="Date")]
       [Required,DataType(DataType.Date)]         
        public DateTime? PresDateEvent { get; set; }

       [Display(Name="Time")]
       [Required,DataType(DataType.Time)]         
        public DateTime? PresTimeEvent { get; set; }
    }
}
