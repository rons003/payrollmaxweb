using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PayrollPeriod
    {
        public string PayrollPeriod1 { get; set; }
        public DateTime? DateOne { get; set; }
        public DateTime? DateTwo { get; set; }
        public string IsLocked { get; set; }
        public int? WorkDays { get; set; }
    }
}
