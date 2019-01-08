using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeTaxStatus
    {
        public string EmployeeNo { get; set; }
        public DateTime TaxStatDate { get; set; }
        public string TaxStatus { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
