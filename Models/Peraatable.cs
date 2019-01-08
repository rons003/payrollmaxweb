using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Peraatable
    {
        public decimal IncomeBracket { get; set; }
        public double? Employer { get; set; }
        public double? Employee { get; set; }
    }
}
