using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class RptContriSummary
    {
        public string EmployeeNo { get; set; }
        public decimal? Sssemployee { get; set; }
        public decimal? PagIbigEmployee { get; set; }
        public decimal? PhilHealthEmployee { get; set; }
        public decimal? WitholdingTax { get; set; }
        public decimal? Gross { get; set; }
    }
}
