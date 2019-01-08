using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class RptPayrollAllocation
    {
        public string EmployeeNo { get; set; }
        public string ProjectCode { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? TotalGross { get; set; }
        public double? Percentage { get; set; }
        public decimal? TotalSalary { get; set; }
        public decimal? Ssscontri { get; set; }
        public decimal? PagIbigContri { get; set; }
        public string PositionGrade { get; set; }
        public decimal? PhealthContri { get; set; }
    }
}
