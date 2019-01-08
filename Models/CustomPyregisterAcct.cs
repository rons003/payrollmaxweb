using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class CustomPyregisterAcct
    {
        public string ReportNo { get; set; }
        public int SeqNo { get; set; }
        public string AccountCode { get; set; }
        public string AccType { get; set; }
        public string EntryType { get; set; }
    }
}
