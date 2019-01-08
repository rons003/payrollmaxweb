using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Organization
    {
        public string EmployeeNo { get; set; }
        public string OrgName { get; set; }
        public string Title { get; set; }
        public DateTime? OrgFrom { get; set; }
        public DateTime? OrgTo { get; set; }
        public string DocFileName { get; set; }
    }
}
