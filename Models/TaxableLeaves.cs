using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class TaxableLeaves
    {
        public string TransYear { get; set; }
        public string EmployeeNo { get; set; }
        public string MonthCode { get; set; }
        public double? Vlhours { get; set; }
        public decimal? Vlamount { get; set; }
        public double? Slhours { get; set; }
        public decimal? Slamount { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? Wtax { get; set; }
        public decimal? VlhoursTax { get; set; }
        public decimal? VlamountTax { get; set; }
        public string IncludeSss { get; set; }
        public string IncludePhealth { get; set; }
        public string IncludePagIbig { get; set; }
        public string IncludeMonth { get; set; }
        public double? SlhoursNonTax { get; set; }
        public double? SlamountNonTax { get; set; }
    }
}
