using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Companies
    {
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public string TaxIdno { get; set; }
        public string PhilHealthNo { get; set; }
        public string PagIbigNo { get; set; }
        public string FaxNo { get; set; }
        public string Sssno { get; set; }
        public string DbaseName { get; set; }
        public string DbasePath { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string CompanyType { get; set; }
        public string TemplateFolder { get; set; }
        public string PictureFolder { get; set; }
    }
}
