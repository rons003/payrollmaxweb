using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PerformanceTable
    {
        public double PercentFrom { get; set; }
        public double PercentTo { get; set; }
        public decimal? Amount { get; set; }
    }
}
