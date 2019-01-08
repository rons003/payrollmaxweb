using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class EmployeeEducation
    {
        public string EmployeeNo { get; set; }
        public string Elementary { get; set; }
        public string ElemSchool { get; set; }
        public string ElemDateGrad { get; set; }
        public string Secondary { get; set; }
        public string SecondSchool { get; set; }
        public string SecondDateGrad { get; set; }
        public string College { get; set; }
        public string CollegeSchool { get; set; }
        public string CollegeDateGrad { get; set; }
        public string Vocational { get; set; }
        public string VocaSchool { get; set; }
        public string VocaDateGrad { get; set; }
        public string Others { get; set; }
        public string OthersSchool { get; set; }
        public string OthersDateGrad { get; set; }
        public string PostDateGrad { get; set; }
        public string PostSchool { get; set; }
        public string PostGrad { get; set; }
    }
}
