using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class ProdHeader
    {
        public ProdHeader()
        {
            ProdDetails = new HashSet<ProdDetails>();
        }

        public string JobNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual ICollection<ProdDetails> ProdDetails { get; set; }
    }
}
