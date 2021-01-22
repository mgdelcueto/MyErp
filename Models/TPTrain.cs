using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TPTrain
    {
        public int TrainId { get; set; }
        public int? TrainPerId { get; set; }

        [Required,DataType(DataType.Date)]         
        public DateTime? TrainDate { get; set; }

       [Required,StringLength(10)]
        public string TrainArea { get; set; }

       [Required,StringLength(10)]
        public string TrainCourse { get; set; }

        [Required,Range(0, 100, ErrorMessage = "Enter valid calification (0 - 100)")]
        public double? TrainCalif { get; set; }

        [DataType(DataType.MultilineText)]
       [Required,StringLength(1250)]
        public string TrainObser { get; set; }
    }
}
