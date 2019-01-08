using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeSlvl
    {
        public string EmployeeNo { get; set; }
        public DateTime EffectivityFrom { get; set; }
        public DateTime? EffectivityTo { get; set; }
        public double? Vacation { get; set; }
        public double? Sick { get; set; }
        public double? VacationUsed { get; set; }
        public double? SickUsed { get; set; }
        public string PayrollPeriod { get; set; }
        public string TransYear { get; set; }
        public double? VacationBalance { get; set; }
        public double? SickBalance { get; set; }
        public double? SickGen { get; set; }
        public double? VacationGen { get; set; }
        public double? SickCon { get; set; }
        public double? VacationCon { get; set; }
        public double? Vlconverted { get; set; }
        public double? Slconverted { get; set; }
        public string ProcessType { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
