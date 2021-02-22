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


        [Display(Name = "My Creation Date")]
        [DataType(DataType.Date)]         
        public DateTime? CplantCrDate { get; set; }
        
        [Display(Name = "My Plant Code")]
        [Required,StringLength(255)]
        public string CplantCode { get; set; }

        [Display(Name = "My Plant Deno")]
        [Required,StringLength(255)]
        public string CplantDeno { get; set; }

        [Display(Name = "My Account")]
        [StringLength(255)]
        public string CplantAcct { get; set; }

        [Display(Name = "My Status Date")]
        [DataType(DataType.Date)]         
        public DateTime? CplantStDate { get; set; }

        [Display(Name = "My Plant Status")]
        [StringLength(25)]
        public string CplantStatus { get; set; }

        [Display(Name = "My Plant Address")]
        [Required,StringLength(255)]
        public string CplantAdStrt { get; set; }

        [Display(Name = "My Plant Address")]
        [StringLength(255)]
        public string CplantAdAdit { get; set; }

        [Display(Name = "My Plant City")]
        [Required,StringLength(255)]
        public string CplantAdCity { get; set; }

        [Display(Name = "My Plant Country")]
        [Required,StringLength(4)]
        public string CplantAdCtry { get; set; }

        [Display(Name = "My Contact Phone")]
        [StringLength(55)]
        public string CplantCtPhone { get; set; }

        [Display(Name = "My email")]
        [StringLength(125)]
        public string CplantCtEmailLog { get; set; }
        
        [Display(Name = "My Web")]
        [StringLength(255)]
        public string CplantCtWeb { get; set; }

        [Display(Name = "My EDI Adress")]
        [StringLength(100)]
        public string CplantCtEdilog { get; set; }

        [Display(Name = "Truck")]
        [Required]
        public int? CplantTruckId { get; set; }
    }
}
