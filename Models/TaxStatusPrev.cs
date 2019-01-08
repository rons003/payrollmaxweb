using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class TaxStatusPrev
    {
        public string StatusCode { get; set; }
        public decimal? PersonalExempt { get; set; }
        public decimal? Dependents { get; set; }
        public decimal? PersonalExemptProRated { get; set; }
        public decimal? DependentsProRated { get; set; }
    }
}
