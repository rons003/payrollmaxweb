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
    }
}
