using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace payroll.Models
{
    public partial class VwsPayrollHeader
    {
        [Key]
        public string EmployeeNo { get; set; }
        public string PayrollPeriod { get; set; }
        public decimal? NetPay { get; set; }
        public string Validated { get; set; }
    }
}