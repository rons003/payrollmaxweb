using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class TardinessTable
    {
        public double MinutesFrom { get; set; }
        public double MinutesTo { get; set; }
        public double? Deduction { get; set; }
    }
}
