using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class DateLocker
    {
        public DateTime TransDate { get; set; }
        public string IsLocked { get; set; }
    }
}
