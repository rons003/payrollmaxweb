using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Reminders
    {
        public string EmployeeNo { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime ReminderDate { get; set; }
        public string Particulars { get; set; }
        public string Status { get; set; }
        public string DocFileName { get; set; }
    }
}
