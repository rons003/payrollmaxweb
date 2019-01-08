using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Education
    {
        public string EmployeeNo { get; set; }
        public string EduLevel { get; set; }
        public string School { get; set; }
        public string Degree { get; set; }
        public double? Units { get; set; }
        public string Honors { get; set; }
        public DateTime? EduFrom { get; set; }
        public DateTime? EduTo { get; set; }
        public string DocFileName { get; set; }
    }
}
