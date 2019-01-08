using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Slvlbracket
    {
        public string Slvlcode { get; set; }
        public double MonthsFrom { get; set; }
        public double? MonthsTo { get; set; }
        public double? VacationLeave { get; set; }
        public double? SickLeave { get; set; }
    }
}
