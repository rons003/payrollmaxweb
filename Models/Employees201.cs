using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201
    {
        public string EmployeeNo { get; set; }
        public DateTime Date201 { get; set; }
        public string Particular { get; set; }
        public string SanctionType { get; set; }
        public string DocFileName { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
