using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class CustomPyregister
    {
        public CustomPyregister()
        {
            CustomPyregsDtl = new HashSet<CustomPyregsDtl>();
        }

        public string ReportNo { get; set; }
        public string ReportName { get; set; }
        public string PaperType { get; set; }
        public double? PaperHeight { get; set; }
        public double? PaperWidth { get; set; }
        public double? Orientation { get; set; }
        public double? TopMargin { get; set; }
        public double? LeftMargin { get; set; }
        public double? RightMargin { get; set; }
        public double? BottomMargin { get; set; }

        public virtual ICollection<CustomPyregsDtl> CustomPyregsDtl { get; set; }
    }
}
