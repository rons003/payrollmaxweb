using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class CustomPyregsDtl
    {
        public string ReportNo { get; set; }
        public int SeqNo { get; set; }
        public string ColumnName { get; set; }
        public string ColumType { get; set; }
        public string WithSeparator { get; set; }
        public int? NoDecimal { get; set; }
        public int? ColLength { get; set; }
        public string IsVisible { get; set; }
        public string HideZero { get; set; }
        public string DispValue { get; set; }

        public virtual CustomPyregister ReportNoNavigation { get; set; }
    }
}
