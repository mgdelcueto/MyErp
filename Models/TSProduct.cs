using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TSProduct
    {
        public int ProdId { get; set; }
        public int? ProdSupId { get; set; }

        [Display(Name="My Cr Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? ProdCrDate { get; set; }

        [Required,StringLength(125)]
        [Display(Name="My Status")]
        public string ProdStatus { get; set; }

        [Display(Name="My Stat Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? ProdStDate { get; set; }

        [Required,StringLength(125)]
        [Display(Name="My Product Refer")]
        public string ProdRefer { get; set; }

        [Required,StringLength(225)]
        [Display(Name="My Description")]
        public string ProdDescr { get; set; }
    }
    public partial class Referencia
    {
        public int ProdId { get; set; }
        public string ProdRefer { get; set; }
    }

}
