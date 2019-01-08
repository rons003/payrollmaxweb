using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class PayrollHeader
    {
        public string PayrollPeriod { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? BasicPay { get; set; }
        public decimal? Otpay { get; set; }
        public decimal? OtherIncome { get; set; }
        public decimal? Month13th { get; set; }
        public decimal? Sssemployee { get; set; }
        public decimal? Sssemployer { get; set; }
        public decimal? Sssec { get; set; }
        public decimal? PhilHealthEmployee { get; set; }
        public decimal? PhilHealthEmployer { get; set; }
        public decimal? PagIbigEmployee { get; set; }
        public decimal? PagIbigEmployer { get; set; }
        public decimal? WitholdingTax { get; set; }
        public decimal? OtherDeduction { get; set; }
        public decimal? Gross { get; set; }
        public decimal? TotalDeductions { get; set; }
        public decimal? NetPay { get; set; }
        public string Department { get; set; }
        public string BankAccountNo { get; set; }
        public string PayrollMode { get; set; }
        public decimal? NonTaxable { get; set; }
        public decimal? Deminimis { get; set; }
        public string EntryType { get; set; }
        public decimal? UnionDues { get; set; }
        public decimal? SssbaseAmount { get; set; }
        public decimal? PhilHealthBaseAmount { get; set; }
        public decimal? PagIbigBaseAmount { get; set; }
        public decimal? TaxBaseAmount { get; set; }
        public string BankCode { get; set; }
        public decimal? Peraaemployee { get; set; }
        public decimal? Peraaemployer { get; set; }
        public decimal? PeraabaseAmount { get; set; }
        public decimal? BillingRate { get; set; }
        public decimal? HealthInsurance { get; set; }
        public decimal? HolidayPay { get; set; }
        public decimal? OvertimePay { get; set; }
        public decimal? NightDiffPay { get; set; }
        public decimal? HazardPay { get; set; }
        public decimal? OtherCompen { get; set; }
        public decimal? Colaamount { get; set; }
        public string WithTin { get; set; }
        public decimal? NonTaxPagIbig { get; set; }
        public string IsMwe { get; set; }
        public decimal? TotalDays { get; set; }
        public decimal? TotalHrs { get; set; }
        public decimal? Sssloan { get; set; }
        public decimal? PagibigLoan { get; set; }
        public decimal? OtherLoan { get; set; }
        public decimal? Othrs { get; set; }
        public decimal? Splhrs { get; set; }
        public decimal? Leghrs { get; set; }
        public decimal? Sunhrs { get; set; }
        public decimal? Splpay { get; set; }
        public decimal? Legpay { get; set; }
        public decimal? Sunpay { get; set; }
        public decimal? CalamityLoan { get; set; }
        public string Branch { get; set; }
        public string PayrollType { get; set; }
        public string Validated { get; set; }
    }
}
