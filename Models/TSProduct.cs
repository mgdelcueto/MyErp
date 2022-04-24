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

        [Display(Name="ProDateCrea")]
        [Required,DataType(DataType.Date)]         
        public DateTime? ProdCrDate { get; set; }

        [Required,StringLength(125)]
        [Display(Name="Status")]
        public string ProdStatus { get; set; }

        [Display(Name="StatusDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? ProdStDate { get; set; }

        [Required,StringLength(125)]
        [Display(Name="ProRefer")]
        public string ProdRefer { get; set; }

        [Required,StringLength(225)]
        [Display(Name="ProDescr")]
        public string ProdDescr { get; set; }
    }
    public partial class Referencia
    {
        public int ProdId { get; set; }
        public string ProdRefer { get; set; }
    }

}
