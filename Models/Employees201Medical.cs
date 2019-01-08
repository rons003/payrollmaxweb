using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Medical
    {
        public string EmployeeNo { get; set; }
        public string MedicalNo { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public DateTime? MedicalDate { get; set; }
        public string Venue { get; set; }
        public string Physician { get; set; }
        public string Findings1 { get; set; }
        public string Findings2 { get; set; }
        public string DocFileName { get; set; }
    }
}
