using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class VoucherAccount
    {
        public string VoucherCode { get; set; }
        public int SeqNo { get; set; }
        public string AccountCode { get; set; }
        public string AccountType { get; set; }
        public string EntryType { get; set; }

        public virtual VoucherDetails VoucherDetails { get; set; }
    }
}
