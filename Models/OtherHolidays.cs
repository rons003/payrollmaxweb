using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class OtherHolidays
    {
        public DateTime TransDate { get; set; }
        public string EmployeeNo { get; set; }
        public string HolidayType { get; set; }
        public DateTime? CheckDate1 { get; set; }
        public DateTime? CheckDate2 { get; set; }
    }
}
