using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeSchedule
    {
        public string EmployeeNo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ScheduleCode { get; set; }
        public string RestDay { get; set; }
        public string WithOvertime { get; set; }
        public string WithTardiness { get; set; }
        public string IsFlexiTime { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
