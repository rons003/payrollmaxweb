using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class BonusPerfHeader
    {
        public string MonthCode { get; set; }
        public string TaxType { get; set; }
        public string PayrollPeriod1 { get; set; }
        public string PayrollPeriod2 { get; set; }
        public string IncludeSss { get; set; }
        public string IncludePhealth { get; set; }
        public string IncludePagIbig { get; set; }
        public string IncludeMonth01 { get; set; }
        public string IncludeMonth02 { get; set; }
        public string IncludeMonth03 { get; set; }
    }
}
