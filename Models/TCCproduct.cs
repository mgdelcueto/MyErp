using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCCproduct
    {
        public int CprodId { get; set; }

        [Display(Name = "Plant")]
        public int? CprodCplantId { get; set; }
        public int? CprodCustId { get; set; }
        public int? CprodPoid { get; set; }
        [Display(Name = "RefInt")]
        public int? CprodMatInt{get;set;}

        [Display(Name = "Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CprodCrDate { get; set; }

        [Display(Name = "Status")]
        [Required,StringLength(125)]
        public string CprodStatus { get; set; }

        [Display(Name = "RefInt")]
        public string CprodRefInt { get; set; }

        [Display(Name = "Descr")]
        public string CprodDescInt { get; set; }
    }
}
