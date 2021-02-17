using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TUsRol
    {
        public int UsRolId { get; set; }
        public int UsRolUsId { get; set; }
        public string UsRolName { get; set; }
        public DateTime UsRolDateEnd { get; set; }
    }
}
