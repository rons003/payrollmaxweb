using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class HolidayTable
    {
        public string HolidayCode { get; set; }
        public string Description { get; set; }
        public string HolidayType { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? CheckDate02 { get; set; }
        public int? NoOfHolidays { get; set; }
    }
}
