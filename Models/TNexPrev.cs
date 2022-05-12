using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyErp.Models
{
    public partial class TNexPrev
    {
        public int _Id { get; set; }
        public int _Idnext { get; set; }
        public int _idprev { get; set; }


    }
}
