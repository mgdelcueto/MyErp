using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TCPorder
    {
        public int Cpoid { get; set; }
        public int? CpocustId { get; set; }
        public int? CpocplantId { get; set; }

        [Display(Name = "PODate")]
        [Required,DataType(DataType.Date)]         
        public DateTime? Cpodate { get; set; }

        [Display(Name = "Status")]
        [Required,StringLength(25)]
        public string Cpostatus { get; set; }

        [Display(Name = "RefExt")]
        [Required,StringLength(125)]
        public string CporeferEx { get; set; }

        [Display(Name = "Descr")]
        [Required,StringLength(225)]
        public string CpodescEx { get; set; }

        [Range(0, int.MaxValue)]
        public int? CpocprodId { get; set; }

        [Display(Name = "PO")]
        [Required,StringLength(125)]
        public string Cpopo { get; set; }

        [Display(Name = "Price")]
        [Required,Range(0, Double.MaxValue, ErrorMessage = "Enter valid Price (>0 )")]
        public double? Cpoprice { get; set; }

        [Display(Name = "Curcy")]
        [Required,StringLength(25)]

        public string Cpocurcy { get; set; }
    }
}
