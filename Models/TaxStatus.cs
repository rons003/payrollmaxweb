using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class TaxStatus
    {
        public string StatusCode { get; set; }
        public decimal? PersonalExempt { get; set; }
        public decimal? Dependents { get; set; }
    }
}
