using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TSuplier
    {
        public int SupId { get; set; }

        [Display(Name="SupRaSoc")]
        [Required,StringLength(125)]
        public string SupRasoc { get; set; }

        [Display(Name="NIF")]
        [Required,StringLength(10)]
        public string SupNif { get; set; }

        [Display(Name="SupCrDate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? SupCrDate { get; set; }

        [Display(Name="SupCode")]
        [Required,StringLength(225)]
        public string SupCode { get; set; }

        [Display(Name="SupAccount")]
        [StringLength(225)]
        public string SupAcct { get; set; }

        [Display(Name="SupAdress")]
        [Required,StringLength(225)]
        public string SupAdStrt { get; set; }

        [Display(Name="SupAdressA")]
        [StringLength(225)]
        public string SupAdAdit { get; set; }

        [Display(Name="SupCity")]
        [Required,StringLength(225)]
        public string SupAdCity { get; set; }

        [Display(Name="SupCountry")]
        [Required,StringLength(4)]
        public string SupAdCtry { get; set; }

        [Display(Name="SupPhone")]
        [Required,StringLength(55)]
        public string SupCtPhone { get; set; }

        [Display(Name="SupemailLOG")]
        [Required,StringLength(125)]
        public string SupCtEmailLog { get; set; }

        [Display(Name="SupemailFIN")]
        [StringLength(125)]
        public string SupCtEmailFin { get; set; }

        [Display(Name="SupWebSite")]
        [StringLength(225)]
        public string SupCtWeb { get; set; }

        [Display(Name="SupEDILOG")]
        [Required,StringLength(100)]
        public string SupCtEdilog { get; set; }

        [Display(Name="SupEDIFIN")]
        [StringLength(100)]
        public string SupCtEdifin { get; set; }

        [Display(Name="SupBankAcc")]
        [StringLength(225)]
        public string SupCtBankAcc { get; set; }

        [Display(Name="SupStatus")]
        [StringLength(25)]
        public string SupStatus { get; set; }

        [Display(Name="SupStatusDate")]
        [DataType(DataType.Date)]         
        public DateTime? SupStDate { get; set; }
    }
}
