using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ScheduleCalendarEmp
    {
        public ScheduleCalendarEmp()
        {
            ScheduleEmpBreakTime = new HashSet<ScheduleEmpBreakTime>();
        }

        public string EmployeeNo { get; set; }
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
        public DateTime? ActualTimeIn { get; set; }
        public DateTime? ActualTimeOut { get; set; }
        public string IsUpdated { get; set; }

        public virtual ICollection<ScheduleEmpBreakTime> ScheduleEmpBreakTime { get; set; }
    }
}
