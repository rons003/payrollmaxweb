using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class BonusDetails
    {
        public string TransYear { get; set; }
        public string BonusType { get; set; }
        public string EmployeeNo { get; set; }
        public string ComputationType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Wtax { get; set; }
        public double? PercentRate { get; set; }
    }
}
