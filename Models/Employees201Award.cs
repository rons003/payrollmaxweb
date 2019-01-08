using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Award
    {
        public string EmployeeNo { get; set; }
        public string Award { get; set; }
        public string Institution { get; set; }
        public DateTime GivenDate { get; set; }
        public string DocFileName { get; set; }
    }
}
