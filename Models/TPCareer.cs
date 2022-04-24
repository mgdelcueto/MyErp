using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPCareer
    {
        public int CareId { get; set; }
        public int? CarePerId { get; set; }

        [Display(Name="Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CareDate { get; set; }

        [Display(Name="Position")]
        [Required,StringLength(10)]
        public string CarePosit { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name="Observations")]
        [StringLength(1250)]
        public string CareObser { get; set; }
    }
}
