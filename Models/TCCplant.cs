using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCCplant
    {
        public int? CplantId { get; set; }
        public int? CplantCustId { get; set; }


        [Display(Name = "CreDate")]
        [DataType(DataType.Date)]         
        public DateTime? CplantCrDate { get; set; }
        
        [Display(Name = "Code")]
        [Required,StringLength(255)]
        public string CplantCode { get; set; }

        [Display(Name = "Deno")]
        [Required,StringLength(255)]
        public string CplantDeno { get; set; }

        [Display(Name = "Account")]
        [StringLength(255)]
        public string CplantAcct { get; set; }

        [Display(Name = "StatusDate")]
        [DataType(DataType.Date)]         
        public DateTime? CplantStDate { get; set; }

        [Display(Name = "Status")]
        [StringLength(25)]
        public string CplantStatus { get; set; }

        [Display(Name = "Address")]
        [Required,StringLength(255)]
        public string CplantAdStrt { get; set; }

        [Display(Name = "Address")]
        [StringLength(255)]
        public string CplantAdAdit { get; set; }

        [Display(Name = "City")]
        [Required,StringLength(255)]
        public string CplantAdCity { get; set; }

        [Display(Name = "Country")]
        [Required,StringLength(4)]
        public string CplantAdCtry { get; set; }

        [Display(Name = "Phone")]
        [StringLength(55)]
        public string CplantCtPhone { get; set; }

        [Display(Name = "email")]
        [StringLength(125)]
        public string CplantCtEmailLog { get; set; }
        
        [Display(Name = "WebSite")]
        [StringLength(255)]
        public string CplantCtWeb { get; set; }

        [Display(Name = "EDIAdress")]
        [StringLength(100)]
        public string CplantCtEdilog { get; set; }

        [Display(Name = "Truck")]
        public int? CplantTruckId { get; set; }
    }
}
