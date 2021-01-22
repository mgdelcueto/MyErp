using System;
using System.Collections.Generic;

#nullable disable

namespace MyErp.Models
{
    public partial class TCCplantPort
    {
        public int PortId { get; set; }
        public int? PortCplantId { get; set; }
        public DateTime? PortCrDate { get; set; }
        public string PortCode { get; set; }
        public string PortAcct { get; set; }
        public DateTime? PortStDate { get; set; }
        public string PortStatus { get; set; }
        public string PortAdStrt { get; set; }
        public string PortAdAdit { get; set; }
        public string PortAdCity { get; set; }
        public string PortAdCtry { get; set; }
        public string PortDock { get; set; }
        public string PortCtPhone { get; set; }
        public string PortCtEmailLog { get; set; }
        public string PortCtEdilog { get; set; }
    }
}
