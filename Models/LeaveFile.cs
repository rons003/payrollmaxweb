using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class LeaveFile
    {
        public string EmployeeNo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string LeaveType { get; set; }
        public string Remarks { get; set; }
        public string LeaveCode { get; set; }
    }
}
