using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeSlvldetails
    {
        public string EmployeeNo { get; set; }
        public DateTime TransDate { get; set; }
        public string LeaveType { get; set; }
        public double? NoOfHours { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
