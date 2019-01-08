using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Relative
    {
        public string EmployeeNo { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Status { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string Relative { get; set; }
        public string DocFileName { get; set; }
    }
}
