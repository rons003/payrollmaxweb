using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class RptSlvl
    {
        public string EmployeeNo { get; set; }
        public double? Vacation { get; set; }
        public double? Sick { get; set; }
        public double? VacationUsed { get; set; }
        public double? SickUnused { get; set; }
        public double? SickUsed { get; set; }
        public decimal? SickAmount { get; set; }
        public decimal? VacationAmount { get; set; }
        public double? VacationUnused { get; set; }
    }
}
