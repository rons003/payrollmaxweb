using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Pagibigtable
    {
        public decimal IncomeBracket { get; set; }
        public double? Employer { get; set; }
        public double? Employee { get; set; }
        public decimal? MaxContribution { get; set; }
        public string Status { get; set; }
    }
}
