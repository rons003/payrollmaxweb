using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class BonusPerfDetails
    {
        public string MonthCode { get; set; }
        public string EmployeeNo { get; set; }
        public string ComputationType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Wtax { get; set; }
        public double? PercentRate { get; set; }
    }
}
