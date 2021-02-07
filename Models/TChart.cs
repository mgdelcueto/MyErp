using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TChart
    {
        public int CharId { get; set; }
        public int? CharHeadId { get; set; }
        public string CharCode { get; set; }
        public string CharName { get; set; }
        public DateTime? CharDate { get; set; }
        public string CharAdress { get; set; }
        public string CharAdressad { get; set; }
        public string CharTel { get; set; }
        public string CharWeb { get; set; }
        public string CharEmail { get; set; }
        public string CharCtry { get; set; }
        public string CharCity { get; set; }
    }
}
