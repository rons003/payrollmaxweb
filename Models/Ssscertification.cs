using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Ssscertification
    {
        public string EmployeeNo { get; set; }
        public string MonthCode { get; set; }
        public int? YearCode { get; set; }
        public string MonthDesc { get; set; }
        public decimal? AmountPaid { get; set; }
        public string PreparedBy { get; set; }
        public string CertifiedBy { get; set; }
        public string Sbrno { get; set; }
        public DateTime? TransDate { get; set; }
        public string TitleDesc { get; set; }
    }
}
