using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TSuplier
    {
        public int SupId { get; set; }

        [Display(Name="My Razon Social")]
        [Required,StringLength(125)]
        public string SupRasoc { get; set; }

        [Display(Name="My NIF")]
        [Required,StringLength(10)]
        public string SupNif { get; set; }

        [Display(Name="Creation Date")]
        [Required,DataType(DataType.Date)]         
        public DateTime? SupCrDate { get; set; }

        [Display(Name="My Sup Code")]
        [Required,StringLength(225)]
        public string SupCode { get; set; }

        [Display(Name="My Account")]
        [StringLength(225)]
        public string SupAcct { get; set; }

        [Display(Name="My Adress")]
        [Required,StringLength(225)]
        public string SupAdStrt { get; set; }

        [Display(Name="My Adress")]
        [StringLength(225)]
        public string SupAdAdit { get; set; }

        [Display(Name="My City")]
        [Required,StringLength(225)]
        public string SupAdCity { get; set; }

        [Display(Name="My Country")]
        [Required,StringLength(4)]
        public string SupAdCtry { get; set; }

        [Display(Name="My Phone")]
        [Required,StringLength(55)]
        public string SupCtPhone { get; set; }

        [Display(Name="My email (LOG)")]
        [Required,StringLength(125)]
        public string SupCtEmailLog { get; set; }

        [Display(Name="My email (FIN)")]
        [StringLength(125)]
        public string SupCtEmailFin { get; set; }

        [Display(Name="My web site")]
        [StringLength(225)]
        public string SupCtWeb { get; set; }

        [Display(Name="My EDI LOG")]
        [Required,StringLength(100)]
        public string SupCtEdilog { get; set; }

        [Display(Name="My EDI FIN")]
        [StringLength(100)]
        public string SupCtEdifin { get; set; }

        [Display(Name="My Bank Acxcount")]
        [StringLength(225)]
        public string SupCtBankAcc { get; set; }

        [Display(Name="My Status")]
        [StringLength(25)]
        public string SupStatus { get; set; }

        [Display(Name="St Date")]
        [DataType(DataType.Date)]         
        public DateTime? SupStDate { get; set; }
    }
}
