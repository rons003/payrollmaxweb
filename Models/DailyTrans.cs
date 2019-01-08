using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class DailyTrans
    {
        public string GroupCode { get; set; }
        public string EmployeeNo { get; set; }
        public string TransType { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime TransTime { get; set; }
        public string TransType02 { get; set; }
        public string Remarks { get; set; }
    }
}
