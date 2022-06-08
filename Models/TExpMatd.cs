using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TExpMatd
    {
	    public int? expcomp {get;set;}
	    public string matrefer {get;set;}
	    public string matdescr {get;set;}
        public double? TComQty {get;set;}
	    public string matunmed {get;set;}
	    public int? SPoId {get;set;}
	    public int? SPoSupId {get;set;}
	    public int? SPOReferEx {get;set;}
	    public string SPOPO {get;set;}
	    public double? SPOPrice {get;set;}
	    public string SPoCurcy {get;set;}
	    public double? SPoPcRep {get;set;}
	    public int? SupId {get;set;}
	    public string SupRaSoc {get;set;}
	    public double? SPoPcRequ {get;set;}
    }
}
