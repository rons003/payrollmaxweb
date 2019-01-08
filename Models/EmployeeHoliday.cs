using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeHoliday
    {
        public string EmployeeNo { get; set; }
        public string HolidayCode { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? CheckDate02 { get; set; }
    }
}
