using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class LoanFile
    {
        public string EmployeeNo { get; set; }
        public string AccountCode { get; set; }
        public string LoanRefNo { get; set; }
        public string StartOfDeduction { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? AmountGranted { get; set; }
        public DateTime? LoanDate { get; set; }
        public string TermsOfPayment { get; set; }
        public decimal? Amortization { get; set; }
        public decimal? TotalCredit { get; set; }
        public string LastPayment { get; set; }
        public string Status { get; set; }
        public double? TotalCash { get; set; }
        public double? TotalPayroll { get; set; }
        public double? TempTotalCredit { get; set; }
        public string Brand { get; set; }
        public string Terms { get; set; }
        public string Particular { get; set; }
        public decimal? Lcpprice { get; set; }
        public decimal? SpotCashAmount { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? Rebate { get; set; }
        public string RebateApplication { get; set; }
        public decimal? LoanInterest { get; set; }
        public string OrigBcode { get; set; }
        public string OrigBname { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string RelativeName { get; set; }
        public DateTime? DateInActive { get; set; }
        public DateTime? FirstDueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? MonthlyDueDate { get; set; }
        public string Saperror { get; set; }
        public string Sapbpcode { get; set; }
        public string SapdocEntry { get; set; }
        public decimal? Saparcount { get; set; }
    }
}
