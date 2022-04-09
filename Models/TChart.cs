using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TChart
    {
        public int CharId { get; set; }
        [Display(Name = "CharHeadId")]
        public int? CharHeadId { get; set; }

        [Display(Name = "CharCode")]
        [Required(ErrorMessage="mCharCode"),StringLength(125, MinimumLength = 3)]
        public string CharCode { get; set; }

        [Display(Name = "CharName")]
        [Required(ErrorMessage="mCharName"),StringLength(225)]
        public string CharName { get; set; }

        [Display(Name = "CharDate")]
        [Required(ErrorMessage="mCharDate"),DataType(DataType.Date)]         
        public DateTime? CharDate { get; set; }

        [Display(Name = "CharAdress")]
        [Required(ErrorMessage="mCharAdress"),StringLength(225)]
        public string CharAdress { get; set; }

        [Display(Name = "CharAdressad")]
        [Required(ErrorMessage="mCharAdressad"),StringLength(225)]
        public string CharAdressad { get; set; }

        [Display(Name = "CharTel")]
        [Required(ErrorMessage="mCharTel"),StringLength(125)]
        public string CharTel { get; set; }

        [Display(Name = "CharWeb")]
        [Required(ErrorMessage="mCharWeb"),StringLength(125)]
        public string CharWeb { get; set; }

        [Display(Name = "CharEmail")]
        [Required(ErrorMessage="mCharEmail"),StringLength(125)]
        public string CharEmail { get; set; }

        [Display(Name = "CharCtry")]
        [Required(ErrorMessage="mCharCtry"),StringLength(125)]
        public string CharCtry { get; set; }

        [Display(Name = "CharCity")]
        [Required(ErrorMessage="mCharCity"),StringLength(125)]
        public string CharCity { get; set; }
    }
}
