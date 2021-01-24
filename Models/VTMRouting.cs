using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{   public partial class VTMRouting
    {
        public int RoRoId { get; set; }
        public int RoRoWCId { get; set; }
        public string RoRoWCDe { get; set; }
        public int RoRoMatId { get; set; }
        public string RoRoMatRe { get; set; }
        public string RoRoMatDe { get; set; }
        public string RoRoFase { get; set; }
        public string RoRoOper { get; set; }
        public double RoRoWunit { get; set; }
        public double RoRoWtime { get; set; }
        public string RoRoTunit { get; set; }
    }
}
