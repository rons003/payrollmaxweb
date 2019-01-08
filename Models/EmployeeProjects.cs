using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeProjects
    {
        public string EmployeeNo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string ProjectCode { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
