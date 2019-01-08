using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Salesman
    {
        public string SalesmanCode { get; set; }
        public string Branch { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public string NextAvailable { get; set; }
        public string UserPword { get; set; }
        public string Locked { get; set; }
        public string Department { get; set; }
        public string IsSalesman { get; set; }
        public string OtherName { get; set; }
        public string UserLevel { get; set; }
        public string ProductGroup { get; set; }
        public string QuotationLocation { get; set; }
        public string MenuSubItems { get; set; }
        public string ConfiLevel { get; set; }
        public DateTime? LastLogin { get; set; }
        public string NoChange { get; set; }
        public string NoExpire { get; set; }
        public DateTime? LastChange { get; set; }
        public string UsrInfo { get; set; }
    }
}
