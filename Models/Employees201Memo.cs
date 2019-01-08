using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Memo
    {
        public string EmployeeNo { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime MemoFrom { get; set; }
        public DateTime MemoTo { get; set; }
        public string MemoType { get; set; }
        public string Particulars { get; set; }
        public string DocFileName { get; set; }
    }
}
