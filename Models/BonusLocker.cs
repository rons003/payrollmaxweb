using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class BonusLocker
    {
        public string MonthCode { get; set; }
        public string BonusType { get; set; }
        public string IsLocked { get; set; }
    }
}
