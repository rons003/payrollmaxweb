using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PayrollTrans02
    {
        public string PayrollPeriod { get; set; }
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
    }
}
