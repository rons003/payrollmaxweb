using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class SalaryAdjustment
    {
        public string PayrollPeriod { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public decimal? BillingRate { get; set; }
        public decimal? MonthlyAllowance { get; set; }
        public decimal? DailyAllowance { get; set; }
        public double? RateDivisor { get; set; }
        public decimal? CurMonthlyRate { get; set; }
        public decimal? CurDailyRate { get; set; }
        public decimal? CurBillingRate { get; set; }
        public decimal? CurMonthlyAllowance { get; set; }
        public decimal? CurDailyAllowance { get; set; }
        public double? CurRateDivisor { get; set; }
    }
}
