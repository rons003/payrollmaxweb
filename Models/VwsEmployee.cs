using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace payroll.Models
{
    public partial class VwsEmployee
    {
        [Key]
        public string EmployeeNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string MiddleInitial { get; set; }
        public string SuffixName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Birthday { get; set; }
        public string EmpPosition { get; set; }
        public string Address01 { get; set; }
        public string Telephone01 { get; set; }
        public DateTime DateHired { get; set; }
        public string SSSNo { get; set; }
        public string PhilHealthNo { get; set; }
        public string PagIbigNo { get; set; }
        public string TaxIDNo { get; set; }
        public string TaxStatus { get; set; }
    }
}
