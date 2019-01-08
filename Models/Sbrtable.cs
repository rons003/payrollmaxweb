using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Sbrtable
    {
        public string MonthCode { get; set; }
        public string Month12 { get; set; }
        public short? TransYear { get; set; }
        public string Sss { get; set; }
        public DateTime? Sssdate { get; set; }
        public string PagIbig { get; set; }
        public DateTime? PagIbigDate { get; set; }
        public string PhilHealth { get; set; }
        public DateTime? PhilHealthDate { get; set; }
        public DateTime? TransDate { get; set; }
        public string MonthDesc { get; set; }
        public string Sssloan { get; set; }
        public DateTime? SssloanDate { get; set; }
        public string PagIbigLoan { get; set; }
        public DateTime? PagIbigLoanDate { get; set; }
        public string SFileName { get; set; }
        public string EmployerName { get; set; }
        public DateTime? Tdate { get; set; }
        public string EmployerId { get; set; }
        public decimal? Sssamount { get; set; }
        public decimal? Sssec { get; set; }
        public int? EmpCont { get; set; }
        public string SignatoryName { get; set; }
        public string SignatoryPosition { get; set; }
    }
}
