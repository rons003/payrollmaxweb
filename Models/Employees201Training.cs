using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees201Training
    {
        public string EmployeeNo { get; set; }
        public string Training { get; set; }
        public string Institution { get; set; }
        public string Venue { get; set; }
        public string Conductor { get; set; }
        public DateTime? TrainFrom { get; set; }
        public DateTime? TrainTo { get; set; }
        public string DocFileName { get; set; }
    }
}
