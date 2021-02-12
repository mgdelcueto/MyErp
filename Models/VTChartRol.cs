using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VTChartRol
    {
        public int RcharId { get; set; }

        [Display(Name = "CharId")]
        public int RcharCharId { get; set; }

        [Display(Name = "RolId")]
        public int RcharRolId { get; set; }

        [Display(Name = "Name")]
        public string RcharPerName {get; set;}
    }
}
