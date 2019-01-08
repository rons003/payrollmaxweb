using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Schedule
    {
        public string ScheduleCode { get; set; }
        public string Description { get; set; }
        public DateTime? Weekdays01 { get; set; }
        public DateTime? Weekdays02 { get; set; }
        public DateTime? Sundays01 { get; set; }
        public DateTime? Sundays02 { get; set; }
        public DateTime? Holidays01 { get; set; }
        public DateTime? Holidays02 { get; set; }
        public string DefaultSched { get; set; }
        public double? BreakTimeHours { get; set; }
        public DateTime? BreakTime01 { get; set; }
        public DateTime? BreakTime02 { get; set; }
        public string IsMiddeduct { get; set; }
        public DateTime? Break01In { get; set; }
        public DateTime? Break01Out { get; set; }
        public string IsB1deduct { get; set; }
        public DateTime? Break02In { get; set; }
        public DateTime? Break02Out { get; set; }
        public string IsB2deduct { get; set; }
        public DateTime? Break03In { get; set; }
        public DateTime? Break03Out { get; set; }
        public string IsB3deduct { get; set; }
        public DateTime? Break04In { get; set; }
        public DateTime? Break04Out { get; set; }
        public string IsB4deduct { get; set; }
        public DateTime? Otbreak01In { get; set; }
        public DateTime? Otbreak01Out { get; set; }
        public string IsOt1deduct { get; set; }
        public DateTime? Otbreak02In { get; set; }
        public DateTime? Otbreak02Out { get; set; }
        public string IsOt2deduct { get; set; }
        public int? MidBreakHrs { get; set; }
    }
}
