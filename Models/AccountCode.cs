using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class AccountCode
    {
        public string AccountCode1 { get; set; }
        public string AccountType { get; set; }
        public string AccountDesc { get; set; }
        public double? PercentDaily { get; set; }
        public double? PercentMonthly { get; set; }
        public string Include13th { get; set; }
        public string Deminimis { get; set; }
        public string NonTaxable { get; set; }
        public string IsHealth { get; set; }
        public string PayrollRegCode { get; set; }
    }
}
