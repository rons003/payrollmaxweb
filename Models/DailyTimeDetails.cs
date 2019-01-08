using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class DailyTimeDetails
    {
        public string EmployeeNo { get; set; }
        public DateTime TransDate { get; set; }
        public string PayrollPeriod { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public double? RegularHrs { get; set; }
        public double? Absences { get; set; }
        public double? Tardiness { get; set; }
        public double? ExcessHrs { get; set; }
        public double? ApprovedOt { get; set; }
        public double? Holiday { get; set; }
        public double? NightDiff { get; set; }
        public double? SickLeave { get; set; }
        public double? VacationLeave { get; set; }
        public double? PaternityLeave { get; set; }
        public string InOutStatus { get; set; }
        public double? NightDiffOt { get; set; }
        public string LeaveCode { get; set; }
        public double? OtherDeduction { get; set; }
        public decimal? DeductibleAmount { get; set; }
        public string ProjectCode { get; set; }
        public double? BaseRegularHrs { get; set; }
        public double? RegularMins { get; set; }
        public double? AbsencesMins { get; set; }
        public double? TardinessMins { get; set; }
        public double? ExcessMins { get; set; }
        public double? ApprovedOtmins { get; set; }
        public double? HolidayMins { get; set; }
        public double? NightDiffMins { get; set; }
        public double? SickLeaveMins { get; set; }
        public double? VacationLeaveMins { get; set; }
        public double? PaternityLeaveMins { get; set; }
        public double? NightDiffOtmins { get; set; }
        public double? OtherDeductionMins { get; set; }
        public double? BaseRegularMins { get; set; }
        public double? ApprovedNdiffOthrs { get; set; }
        public double? ApprovedNdiffOtmins { get; set; }
        public string NextDayTime { get; set; }
        public int? EarlyOthrs { get; set; }
        public int? EarlyOtmins { get; set; }
        public int? ApprovedEarlyOthrs { get; set; }
        public int? ApprovedEarlyOtmins { get; set; }
        public string DispTimeIn { get; set; }
        public string DispTimeOut { get; set; }
        public string UnderApproved { get; set; }
        public string ConfirmAtt { get; set; }
        public string Comment { get; set; }
    }
}
