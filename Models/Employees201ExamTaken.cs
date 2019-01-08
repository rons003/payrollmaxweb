using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201ExamTaken
    {
        public string EmployeeNo { get; set; }
        public string Code { get; set; }
        public string Place { get; set; }
        public double? Rating { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? DateExam { get; set; }
        public DateTime? DateRelease { get; set; }
        public string DocFileName { get; set; }
    }
}
