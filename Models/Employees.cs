using System;
using System.Collections.Generic;

namespace payroll.Models
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeeEducationNew = new HashSet<EmployeeEducationNew>();
            EmployeeProjects = new HashSet<EmployeeProjects>();
            EmployeeSchedule = new HashSet<EmployeeSchedule>();
            EmployeeSlvl = new HashSet<EmployeeSlvl>();
            EmployeeSlvldetails = new HashSet<EmployeeSlvldetails>();
            EmployeeTaxStatus = new HashSet<EmployeeTaxStatus>();
            Employees201 = new HashSet<Employees201>();
            EmployeesRecurring = new HashSet<EmployeesRecurring>();
        }

        public string EmployeeNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string MiddleInitial { get; set; }
        public string SuffixName { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? DateFinish { get; set; }
        public string EmpStatus { get; set; }
        public string PayrollMode { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public string Sssno { get; set; }
        public string PhilHealthNo { get; set; }
        public string PagIbigNo { get; set; }
        public string TaxIdno { get; set; }
        public string BankAccountNo { get; set; }
        public string EmpPosition { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string Telephone01 { get; set; }
        public string Telephone02 { get; set; }
        public DateTime? Birthday { get; set; }
        public string CivilStatus { get; set; }
        public string Gender { get; set; }
        public string WithSss { get; set; }
        public string WithPhilHealth { get; set; }
        public string WithTin { get; set; }
        public string WithPagibig { get; set; }
        public string TaxStatus { get; set; }
        public DateTime? DateOfClearance { get; set; }
        public string PayrollTerms { get; set; }
        public string ScheduleCode { get; set; }
        public string WithOvertime { get; set; }
        public string WithTardiness { get; set; }
        public string RestDay { get; set; }
        public string IsFlexiTime { get; set; }
        public decimal? Colaamount { get; set; }
        public string ConfiLevel { get; set; }
        public string TimeKeepingId { get; set; }
        public string CustomPycode { get; set; }
        public double? RateDivisor { get; set; }
        public decimal? MonthlyAllowance { get; set; }
        public decimal? DailyAllowance { get; set; }
        public string BankCode { get; set; }
        public string WithPeraa { get; set; }
        public string Peraano { get; set; }
        public string WithUndertime { get; set; }
        public string AttendanceExempt { get; set; }
        public double? TimekeepingAbsHrs { get; set; }
        public double? TimekeepingAbsMins { get; set; }
        public decimal? BillingRate { get; set; }
        public string Slvlcode { get; set; }
        public string SchedAllow { get; set; }
        public string SchedPass { get; set; }
        public double? GracePeriod { get; set; }
        public string TardySetup { get; set; }
        public string UseTardyTable { get; set; }
        public string IncludeGracePeriod { get; set; }
        public double? MaxTardiness { get; set; }
        public double? DaysOfYear { get; set; }
        public string TaxStart { get; set; }
        public string TaxEnd { get; set; }
        public DateTime? DateRegular { get; set; }
        public string Remarks { get; set; }
        public string DepCode { get; set; }
        public string AsBranchCode { get; set; }
        public decimal? DftLeaveCredit { get; set; }
        public string TerminationStatus { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual ICollection<EmployeeEducationNew> EmployeeEducationNew { get; set; }
        public virtual ICollection<EmployeeProjects> EmployeeProjects { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedule { get; set; }
        public virtual ICollection<EmployeeSlvl> EmployeeSlvl { get; set; }
        public virtual ICollection<EmployeeSlvldetails> EmployeeSlvldetails { get; set; }
        public virtual ICollection<EmployeeTaxStatus> EmployeeTaxStatus { get; set; }
        public virtual ICollection<Employees201> Employees201 { get; set; }
        public virtual ICollection<EmployeesRecurring> EmployeesRecurring { get; set; }
    }
}
