using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employees>();
        }

        public string DepartmentCode { get; set; }
        public string DepartmentDesc { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
