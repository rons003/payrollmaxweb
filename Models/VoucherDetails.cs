using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class VoucherDetails
    {
        public VoucherDetails()
        {
            VoucherAccount = new HashSet<VoucherAccount>();
        }

        public string VoucherCode { get; set; }
        public int SeqNo { get; set; }
        public string Description { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string AmountType { get; set; }
        public string GlaccountCode { get; set; }

        public virtual VoucherHeader VoucherCodeNavigation { get; set; }
        public virtual ICollection<VoucherAccount> VoucherAccount { get; set; }
    }
}
