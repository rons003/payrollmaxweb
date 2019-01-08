using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class LoanCashPayment
    {
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public string LoanRefNo { get; set; }
        public string Orno { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public string PayrollPeriod { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
