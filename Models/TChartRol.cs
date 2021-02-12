using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TChartRol
    {
        public int RcharId { get; set; }

        [Display(Name = "CharId")]
        public int RcharCharId { get; set; }

        [Display(Name = "RolId")]
        public int RcharRolId { get; set; }

    }
}
