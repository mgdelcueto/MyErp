using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPReview
    {
        public int RevId { get; set; }
        public int? RevPerId { get; set; }

        [Required,DataType(DataType.Date)]         
        [Display(Name="Date")]
        public DateTime? RevDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Required,StringLength(1250)]
        [Display(Name="Objective")]
        public string RevObj { get; set; }

        [Required,Range(0, 100, ErrorMessage = "Enter valid rating (0 - 100)")]
        [Display(Name="Rating")]
        public double? RevObRat { get; set; }
    }
}
