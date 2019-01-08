using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeesRecurring
    {
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public string Freq { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
