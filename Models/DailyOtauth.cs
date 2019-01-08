using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class DailyOtauth
    {
        public DateTime TransDate { get; set; }
        public string EmployeeNo { get; set; }
        public string IsType { get; set; }
        public double? NoOfHours { get; set; }
        public double? NoOfMins { get; set; }
    }
}
