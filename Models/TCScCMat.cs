using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCScCMat
    {
        public int ShopId { get; set; }
        public string Shopuser {get; set; }
        public int? Shopversion { get; set; }
        public int? Shopsupid { get; set; }
        public int? ShopCprodId { get; set; }
        public DateTime? reqDate { get; set; }
        public double? reqQty { get; set; }
        public string Matrefer {get;set;}
        public string Matdescr {get;set;}
        public string Suprasoc {get; set;}
        public int? uemba {get;set;}
        public double? minlot {get;set;}
        public string popo {get;set;}
        public int? ndelay {get;set;}
        public string unitdelay {get;set;} 
    }
}
