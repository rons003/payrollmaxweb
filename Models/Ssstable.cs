using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Ssstable
    {
        public decimal BracketFrom { get; set; }
        public decimal? BracketTo { get; set; }
        public decimal? Employer { get; set; }
        public decimal? Employee { get; set; }
        public decimal? Ecc { get; set; }
        public string Status { get; set; }
    }
}
