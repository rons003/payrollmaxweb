using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PayrollTrans01
    {
        public string PayrollPeriod { get; set; }
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public double? NoOfHrs { get; set; }
        public double? NoOfMins { get; set; }
        public decimal? TotalHrs { get; set; }
        public decimal? TotalDays { get; set; }
        public string Remarks { get; set; }
    }
}
