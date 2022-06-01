using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VCXplanning
    {
        [Display(Name="Fecha inicio plan")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateFrom { get; set; }
        [Display(Name="Fecha Fin Plan")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateTo { get; set; }
        public bool CPlancStock {get;set;}
    }
}
