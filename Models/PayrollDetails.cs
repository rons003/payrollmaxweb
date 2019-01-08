using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PayrollDetails
    {
        public string PayrollPeriod { get; set; }
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public string LoanRefenceNo { get; set; }
        public double? NoOfHours { get; set; }
        public decimal? Amount { get; set; }
        public double? NoOfMins { get; set; }
        public decimal? BillingAmount { get; set; }
        public decimal? TotalHrs { get; set; }
        public decimal? TotalDays { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        public string Uploaded { get; set; }
        public string Saperror { get; set; }
        public string SapdocNumber { get; set; }
        public DateTime? DateUploaded { get; set; }
        public decimal? SapinsId { get; set; }
        public DateTime? SapinsDate { get; set; }
    }
}
