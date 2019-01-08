using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Dependents
    {
        public string EmployeeNo { get; set; }
        public string DependentName { get; set; }
        public DateTime? DependentBirthday { get; set; }
        public string DependentType { get; set; }
    }
}
