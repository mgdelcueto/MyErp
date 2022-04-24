using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPPay
    {
        public int PayId { get; set; }
        public int? PayPerId { get; set; }

       [Display(Name="StatusDate")]
       [Required,DataType(DataType.Date)]         
        public DateTime? PayStDate { get; set; }

       [Display(Name="ConceptType")]
       [Required,StringLength(10)]
        public string PayType { get; set; }

       [Display(Name="Retention")]
       [Required,StringLength(10)]
        public string PayRet { get; set; }

       [Display(Name="Account")]
       [Required,StringLength(25)]
        public string PayAccount { get; set; }
    }
}
