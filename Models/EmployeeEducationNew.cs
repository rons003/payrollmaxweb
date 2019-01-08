using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeEducationNew
    {
        public string EmployeeNo { get; set; }
        public string SchoolName { get; set; }
        public string CourseDesc { get; set; }
        public string SchoolAddress { get; set; }
        public string YearGraduated { get; set; }

        public virtual Employees EmployeeNoNavigation { get; set; }
    }
}
