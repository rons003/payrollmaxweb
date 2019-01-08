using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Legal
    {
        public string EmployeeNo { get; set; }
        public string CaseNo { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string CourtFiled { get; set; }
        public DateTime? DateFiled { get; set; }
        public string Prosecutor { get; set; }
        public string CaseStatus { get; set; }
        public string DocFileName { get; set; }
    }
}
