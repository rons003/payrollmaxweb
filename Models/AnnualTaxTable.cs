using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class AnnualTaxTable
    {
        public decimal Excess { get; set; }
        public decimal? Base { get; set; }
        public double? Rate { get; set; }
    }
}
