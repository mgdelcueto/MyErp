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

       [Display(Name="My Status Date")]
       [Required,DataType(DataType.Date)]         
        public DateTime? PayStDate { get; set; }

       [Display(Name="My Type")]
       [Required,StringLength(10)]
        public string PayType { get; set; }

       [Display(Name="My Retention code")]
       [Required,StringLength(10)]
        public string PayRet { get; set; }

       [Display(Name="My Account")]
       [Required,StringLength(25)]
        public string PayAccount { get; set; }
    }
}
