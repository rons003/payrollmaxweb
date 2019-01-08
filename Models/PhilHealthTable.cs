using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PhilHealthTable
    {
        public decimal BracketFrom { get; set; }
        public decimal? BracketTo { get; set; }
        public decimal? Base { get; set; }
        public double? Rate { get; set; }
        public decimal? Employer { get; set; }
        public decimal? Employee { get; set; }
        public int? BracketNo { get; set; }
        public string Status { get; set; }
    }
}
