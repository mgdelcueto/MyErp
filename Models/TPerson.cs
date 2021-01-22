using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPerson
    {
        public int PerId { get; set; }

        [Display(Name="My DNI")]
        [Required,StringLength(10)]
        public string PerDni { get; set; }

        [Display(Name="My Bird Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? PerBird { get; set; }

        [Display(Name="My City of Bird")]
        [Required,StringLength(100)]
        public string PerBiCity { get; set; }

        [Display(Name="My Country of Bird")]
        [Required,StringLength(4)]
        public string PerBiCtry { get; set; }

        [Display(Name="My Name")]
        [Required,StringLength(100)]
        public string PerName { get; set; }

        [Display(Name="My Surname")]
        [Required,StringLength(100)]
        public string PerName1 { get; set; }

        [Display(Name="My Adress")]
        [Required,StringLength(255)]
        public string PerAddr { get; set; }

        [Display(Name="My Adress...")]
        [Required,StringLength(255)]
        public string PerAddr1 { get; set; }

        [Display(Name="My Residence Country")]
        [Required,StringLength(4)]
        public string PerAddCtry { get; set; }

        [Display(Name="My Contract Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? PerContDate { get; set; }

        [Display(Name="My Entry Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? PerEntDate { get; set; }

        [Display(Name="My Exit Date")]
        [DataType(DataType.Date)]         
        public DateTime? PerExiDate { get; set; }
    }
}
