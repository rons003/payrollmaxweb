using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201License
    {
        public string EmployeeNo { get; set; }
        public string LicenseType { get; set; }
        public string ExamPlace { get; set; }
        public double? Rating { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? ExamDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string DocFileName { get; set; }
    }
}
