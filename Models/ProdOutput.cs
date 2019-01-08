using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ProdOutput
    {
        public string EmployeeNo { get; set; }
        public DateTime TransDate { get; set; }
        public string JobNo { get; set; }
        public int OperationNo { get; set; }
        public double? Quantity { get; set; }
    }
}
