using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class VoucherHeader
    {
        public VoucherHeader()
        {
            VoucherDetails = new HashSet<VoucherDetails>();
        }

        public string VoucherCode { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<VoucherDetails> VoucherDetails { get; set; }
    }
}
