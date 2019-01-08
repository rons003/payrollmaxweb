using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class DeviceList
    {
        public string TerminalId { get; set; }
        public string Description { get; set; }
        public string Ipaddress { get; set; }
        public string Status { get; set; }
        public string Disabled { get; set; }
        public string InTpe { get; set; }
        public string OutTpe { get; set; }
    }
}
