using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class CustomPysetup
    {
        public string CustomPycode { get; set; }
        public string CustomPydesc { get; set; }
        public double? RateDivisor { get; set; }
        public string Sssschedule01 { get; set; }
        public string Sssschedule02 { get; set; }
        public string Sssschedule03 { get; set; }
        public string Sssschedule04 { get; set; }
        public string Sssschedule05 { get; set; }
        public string Sssschedule06 { get; set; }
        public string SssbaseCode { get; set; }
        public decimal? SssbaseAmount { get; set; }
        public double? SssbasePercent { get; set; }
        public string PhealthSchedule01 { get; set; }
        public string PhealthSchedule02 { get; set; }
        public string PhealthSchedule03 { get; set; }
        public string PhealthSchedule04 { get; set; }
        public string PhealthSchedule05 { get; set; }
        public string PhealthSchedule06 { get; set; }
        public string PhealthBaseCode { get; set; }
        public decimal? PhealthBaseAmount { get; set; }
        public double? PhealthBasePercent { get; set; }
        public string PagIbigSchedule01 { get; set; }
        public string PagIbigSchedule02 { get; set; }
        public string PagIbigSchedule03 { get; set; }
        public string PagIbigSchedule04 { get; set; }
        public string PagIbigSchedule05 { get; set; }
        public string PagIbigSchedule06 { get; set; }
        public string PagIbigBaseCode { get; set; }
        public decimal? PagIbigBaseAmount { get; set; }
        public double? PagIbigBasePercent { get; set; }
        public string PagIbigSubsidy { get; set; }
        public string PagIbigMaximum { get; set; }
        public string TaxSchedule01 { get; set; }
        public string TaxSchedule02 { get; set; }
        public string TaxSchedule03 { get; set; }
        public string TaxSchedule04 { get; set; }
        public string TaxSchedule05 { get; set; }
        public string TaxSchedule06 { get; set; }
        public string TaxBaseCode { get; set; }
        public decimal? TaxBaseAmount { get; set; }
        public double? TaxBasePercent { get; set; }
        public double? TaxRate { get; set; }
        public double? RatePerHourDivisor { get; set; }
        public decimal? FixSssemployee { get; set; }
        public decimal? FixSssemployer { get; set; }
        public decimal? FixSssec { get; set; }
        public decimal? FixPhealthEmployee { get; set; }
        public decimal? FixPhealthEmployer { get; set; }
        public decimal? FixPagIbigEmployee { get; set; }
        public decimal? FixPagIbigEmployer { get; set; }
        public string Peraaschedule01 { get; set; }
        public string Peraaschedule02 { get; set; }
        public string Peraaschedule03 { get; set; }
        public string Peraaschedule04 { get; set; }
        public string Peraaschedule05 { get; set; }
        public string Peraaschedule06 { get; set; }
        public string PeraabaseCode { get; set; }
        public decimal? PeraabaseAmount { get; set; }
        public double? PeraabasePercent { get; set; }
        public string Peraaoption { get; set; }
        public decimal? FixPeraaemployee { get; set; }
        public decimal? FixPeraaemployer { get; set; }
        public string TaxMonthEnd { get; set; }
        public string IncludeSsscola { get; set; }
        public string IncludePhealthCola { get; set; }
        public string IncludePagIbigCola { get; set; }
        public string IncludePeraaCola { get; set; }
        public string IncludeTaxCola { get; set; }
        public string IncludeSssleaves { get; set; }
        public string IncludePhealthLeaves { get; set; }
        public string IncludePagIbigLeaves { get; set; }
        public string IncludePeraaLeaves { get; set; }
        public string IncludeTaxLeaves { get; set; }
    }
}
