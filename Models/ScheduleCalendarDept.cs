using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ScheduleCalendarDept
    {
        public ScheduleCalendarDept()
        {
            ScheduleBreaktimeCalendar = new HashSet<ScheduleBreaktimeCalendar>();
        }

        public string DepartmentNo { get; set; }
        public string MoYear { get; set; }
        public DateTime AppDays { get; set; }
        public string ScheduleSrc { get; set; }
        public double? CellNo { get; set; }
        public string PatternCode { get; set; }
        public string ShiftCode { get; set; }
        public string RestDay { get; set; }
        public string Remarks { get; set; }
        public string IsFlexiTime { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public decimal? RegularHrs { get; set; }
        public decimal? TotalBreak { get; set; }
        public string RevShiftCode { get; set; }
        public DateTime? RevisedTimeIn { get; set; }
        public DateTime? RevisedTimeOut { get; set; }
        public string RevRestDay { get; set; }
        public string RevIsFlexiTime { get; set; }
        public string ActualShiftCode { get; set; }
        public string IsUpdated { get; set; }

        public virtual ICollection<ScheduleBreaktimeCalendar> ScheduleBreaktimeCalendar { get; set; }
    }
}
