using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VCXplanning
    {
        [Display(Name="Fecha inicio plan")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date), Required]
        public DateTime? CplanDateFrom { get; set; }

        [Display(Name="Fecha Fin Plan")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date), Required]
        public DateTime? CplanDateTo { get; set; }
        
        public bool CPlancStock {get;set;}

    }
}
