using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPContract
    {
        public int ConId { get; set; }
        public int? ConPerId { get; set; }

       [Display(Name="My Revision Date")]
       [Required,DataType(DataType.Date)]         
       public DateTime? ConRevDate { get; set; }

        [DataType(DataType.MultilineText)]
       [Display(Name="My Observations")]
       [Required,StringLength(1250)]
       public string ConObs { get; set; }
    }
}
