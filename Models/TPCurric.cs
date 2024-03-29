﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPCurric
    {
        public int CurrId { get; set; }
        public int? CurrPerId { get; set; }

        [Required,DataType(DataType.Date)]         
        [Display(Name = "Date")]
        public DateTime? CurrRevDate { get; set; }

        [Required,StringLength(10, MinimumLength = 3)]
        [Display(Name = "CurrArea")]
        public string CurrArea { get; set; }

        [Required,StringLength(255)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "KAreaDescr")]
        public string CurrAreaDesc { get; set; }

        [Display(Name = "Level")]
        [Required,Range(-1000, 1000, ErrorMessage = "Enter valid level (-1000- 1000)")]
        public double? CurrAreaLevel { get; set; }

        [StringLength(1250)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "CurrObs")]
        public string CurrObs { get; set; }
    }
}
