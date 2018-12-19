using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Reports
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string Path { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
