using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Work
    {
        public string EmployeeNo { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public double? Salary { get; set; }
        public string WorkStatus { get; set; }
        public string Separation { get; set; }
        public DateTime WorkFrom { get; set; }
        public DateTime? WorkTo { get; set; }
        public string DocFileName { get; set; }
    }
}
