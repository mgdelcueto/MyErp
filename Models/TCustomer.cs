using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCustomer
    {
        public int CustId { get; set; }

        [Display(Name = "My Razon Social")]
        [Required,StringLength(125)]
        public string CustRasoc { get; set; }

        [Display(Name = "My CIF/NIF")]
        [Required,StringLength(10)]
        public string CustNif { get; set; }

        [Display(Name = "My Creation Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CustCrDate { get; set; }

        [Display(Name = "My Code")]
        [Required,StringLength(225)]
        public string CustCode { get; set; }

        [Display(Name = "My Account")]
        [StringLength(225)]
        public string CustAcct { get; set; }

        [Display(Name = "My Adress")]
        [Required,StringLength(225)]
        public string CustAdStrt { get; set; }
        
        [Display(Name = "My Adress")]
        [StringLength(225)]
        public string CustAdAdit { get; set; }

        [Display(Name = "My City")]
        [Required,StringLength(225)]
        public string CustAdCity { get; set; }

        [Display(Name = "My Country")]
        [Required,StringLength(4)]
        public string CustAdCtry { get; set; }

        [Display(Name = "My Phone")]
        [Required,StringLength(55)]
        public string CustCtPhone { get; set; }

        [Display(Name = "My email (LOG)")]
        [Required,StringLength(125)]
        public string CustCtEmailLog { get; set; }

        [Display(Name = "My email (FIN)")]
        [StringLength(125)]
        public string CustCtEmailFin { get; set; }

        [Display(Name = "My Web site")]
        [StringLength(225)]
        public string CustCtWeb { get; set; }

        [Display(Name = "My Contact LOG")]
        [Required,StringLength(100)]
        public string CustCtEdilog { get; set; }

        [Display(Name = "My Contact FIN")]
        [StringLength(100)]
        public string CustCtEdifin { get; set; }

        [Display(Name = "My Bank Account")]
        [StringLength(225)]
        public string CustCtBankAcc { get; set; }

        [Display(Name = "My Status")]
        [StringLength(25)]
        public string CustStatus { get; set; }

        [Display(Name = "My Status Date")]
        [DataType(DataType.Date)]         
        public DateTime? CustStDate { get; set; }
    }
}
