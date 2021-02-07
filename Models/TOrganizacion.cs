using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TOrganizacion
    {
        public int OrgId { get; set; }

        [Display(Name="OrgCode")]
        [Required(ErrorMessage="mOrgCode"),StringLength(125)]
        public string OrgCode { get; set; }

        [Display(Name="OrgNif")]
        [Required(ErrorMessage="mOrgNif"),StringLength(125)]
        public string OrgNif { get; set; }

        [Display(Name="OrgName")]
        [Required(ErrorMessage="mOrgName"),StringLength(225)]
        public string OrgName { get; set; }

        [Display(Name="OrgDate")]
        [Required(ErrorMessage="mOrgDate"),DataType(DataType.Date)]         
        public DateTime? OrgDate { get; set; }

        [Display(Name="OrgAdd")]
        [Required(ErrorMessage="mOrgAdd"),StringLength(225)]
        public string OrgAdress { get; set; }

        [Display(Name="OrgAdi")]
        [Required(ErrorMessage="mOrgAdi"),StringLength(225)]
        public string OrgAdressad { get; set; }

        [Display(Name="Telephone")]
        [Required(ErrorMessage="mTelephone"),StringLength(125)]
        public string OrgTel { get; set; }

        [Display(Name="OrgWeb")]
        [Required(ErrorMessage="mOrgWeb"),StringLength(125)]
        public string OrgWeb { get; set; }

        [Display(Name="OrgEmail")]
        [Required(ErrorMessage="mOrgEmail"),StringLength(125)]
        public string OrgEmail { get; set; }

        [Display(Name="Country")]
        [Required(ErrorMessage="mOrgCtry"),StringLength(125)]
        public string OrgCtry { get; set; }

        [Display(Name="City")]
        [Required(ErrorMessage="mOrgCity"),StringLength(125)]
        public string OrgCity { get; set; }
    }
}
