using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class LeaveTable
    {
        public string LeaveCode { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDesc { get; set; }
        public string AccountCode { get; set; }
    }
}
