using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ScheduleEmpBreakTime
    {
        public string EmployeeNo { get; set; }
        public string MoYear { get; set; }
        public DateTime AppDays { get; set; }
        public string IsType { get; set; }
        public DateTime MidBreakIn { get; set; }
        public DateTime MidBreakOut { get; set; }
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
        public int? Break01Hrs { get; set; }
        public int? Break02Hrs { get; set; }
        public int? Break03Hrs { get; set; }
        public int? Break04Hrs { get; set; }
        public int? Otbreak01Hrs { get; set; }
        public int? Otbreak02Hrs { get; set; }
        public int? MidBreakHrs { get; set; }

        public virtual ScheduleCalendarEmp ScheduleCalendarEmp { get; set; }
    }
}
