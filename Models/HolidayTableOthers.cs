using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class HolidayTableOthers
    {
        public DateTime TransDate { get; set; }
        public string HolidayType { get; set; }
        public string HolidayDesc { get; set; }
    }
}
