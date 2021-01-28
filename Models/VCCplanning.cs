using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class VCCplanning
    {
        public int CplanId { get; set; }
        public int? CplanCplantId { get; set; }
        public string CplanCplantCode { get; set; }
        public string CplanCplantDeno { get; set; }
        public int? CplanCustId { get; set; }
        public string CplanCustCode { get; set; }
        public string CplanCustRasoc { get; set; }
        public int? CplanCprodId { get; set; }
        public string CplanCprodRefInt { get; set; }
        public string CplanCprodDescInt { get; set; }
        [Display(Name="Fecha inicio plan")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateFrom { get; set; }
        [Display(Name="Fecha Fin Plan")]
        [Required,DataType(DataType.Date)]         
        public DateTime? CplanDateTo { get; set; }
        public double? CplanQty { get; set; }
        public string CplanFirmSt { get; set; }
    }
}
