using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ProdDetails
    {
        public string JobNo { get; set; }
        public int OperationNo { get; set; }
        public string OperationDesc { get; set; }
        public decimal? PieceRate { get; set; }
        public string Unit { get; set; }

        public virtual ProdHeader JobNoNavigation { get; set; }
    }
}
