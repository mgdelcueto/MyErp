using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCustomer
    {
        public int CustId { get; set; }

        [Display(Name = "RaSoc")]
        [Required,StringLength(125)]
        public string CustRasoc { get; set; }

        [Display(Name = "NIF")]
        [Required,StringLength(10)]
        public string CustNif { get; set; }

        [Display(Name = "CrDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CustCrDate { get; set; }

        [Display(Name = "Code")]
        [Required,StringLength(225)]
        public string CustCode { get; set; }

        [Display(Name = "Account")]
        [StringLength(225)]
        public string CustAcct { get; set; }

        [Display(Name = "Address")]
        [Required,StringLength(225)]
        public string CustAdStrt { get; set; }
        
        [Display(Name = "Address")]
        [StringLength(225)]
        public string CustAdAdit { get; set; }

        [Display(Name = "City")]
        [Required,StringLength(225)]
        public string CustAdCity { get; set; }

        [Display(Name = "Country")]
        [Required,StringLength(4)]
        public string CustAdCtry { get; set; }

        [Display(Name = "Phone")]
        [Required,StringLength(55)]
        public string CustCtPhone { get; set; }

        [Display(Name = "emailLOG")]
        [Required,StringLength(125)]
        public string CustCtEmailLog { get; set; }

        [Display(Name = "emailFIN")]
        [StringLength(125)]
        public string CustCtEmailFin { get; set; }

        [Display(Name = "Website")]
        [StringLength(225)]
        public string CustCtWeb { get; set; }

        [Display(Name = "ContactLOG")]
        [Required,StringLength(100)]
        public string CustCtEdilog { get; set; }

        [Display(Name = "ContactFIN")]
        [StringLength(100)]
        public string CustCtEdifin { get; set; }

        [Display(Name = "CBankAccount")]
        [StringLength(225)]
        public string CustCtBankAcc { get; set; }

        [Display(Name = "Status")]
        [StringLength(25)]
        public string CustStatus { get; set; }

        [Display(Name = "StatusDate")]
        [DataType(DataType.Date)]         
        public DateTime? CustStDate { get; set; }
    }
}
