using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace payroll.Models
{
    public partial class IntegraDbContext : DbContext
    {
        public IntegraDbContext()
        {
        }

        public IntegraDbContext(DbContextOptions<IntegraDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCode> AccountCode { get; set; }
        public virtual DbSet<AnnualTaxTable> AnnualTaxTable { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BonusDetails> BonusDetails { get; set; }
        public virtual DbSet<BonusHeader> BonusHeader { get; set; }
        public virtual DbSet<BonusLocker> BonusLocker { get; set; }
        public virtual DbSet<BonusPerfDetails> BonusPerfDetails { get; set; }
        public virtual DbSet<BonusPerfHeader> BonusPerfHeader { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CustomPyregister> CustomPyregister { get; set; }
        public virtual DbSet<CustomPyregisterAcct> CustomPyregisterAcct { get; set; }
        public virtual DbSet<CustomPyregsDtl> CustomPyregsDtl { get; set; }
        public virtual DbSet<CustomPysetup> CustomPysetup { get; set; }
        public virtual DbSet<DailyOtauth> DailyOtauth { get; set; }
        public virtual DbSet<DailyTimeDetails> DailyTimeDetails { get; set; }
        public virtual DbSet<DailyTimeHeader> DailyTimeHeader { get; set; }
        public virtual DbSet<DailyTrans> DailyTrans { get; set; }
        public virtual DbSet<DateLocker> DateLocker { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DeviceList> DeviceList { get; set; }
        public virtual DbSet<EmployeeDependents> EmployeeDependents { get; set; }
        public virtual DbSet<EmployeeEducation> EmployeeEducation { get; set; }
        public virtual DbSet<EmployeeEducationNew> EmployeeEducationNew { get; set; }
        public virtual DbSet<EmployeeHoliday> EmployeeHoliday { get; set; }
        public virtual DbSet<EmployeeProjects> EmployeeProjects { get; set; }
        public virtual DbSet<EmployeeSchedule> EmployeeSchedule { get; set; }
        public virtual DbSet<EmployeeSlvl> EmployeeSlvl { get; set; }
        public virtual DbSet<EmployeeSlvldetails> EmployeeSlvldetails { get; set; }
        public virtual DbSet<EmployeeTaxStatus> EmployeeTaxStatus { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Employees201> Employees201 { get; set; }
        public virtual DbSet<Employees201Award> Employees201Award { get; set; }
        public virtual DbSet<Employees201Dependents> Employees201Dependents { get; set; }
        public virtual DbSet<Employees201Education> Employees201Education { get; set; }
        public virtual DbSet<Employees201ExamTaken> Employees201ExamTaken { get; set; }
        public virtual DbSet<Employees201Header> Employees201Header { get; set; }
        public virtual DbSet<Employees201Legal> Employees201Legal { get; set; }
        public virtual DbSet<Employees201License> Employees201License { get; set; }
        public virtual DbSet<Employees201Medical> Employees201Medical { get; set; }
        public virtual DbSet<Employees201Memo> Employees201Memo { get; set; }
        public virtual DbSet<Employees201Organization> Employees201Organization { get; set; }
        public virtual DbSet<Employees201Relative> Employees201Relative { get; set; }
        public virtual DbSet<Employees201Reminders> Employees201Reminders { get; set; }
        public virtual DbSet<Employees201Skill> Employees201Skill { get; set; }
        public virtual DbSet<Employees201Training> Employees201Training { get; set; }
        public virtual DbSet<Employees201Work> Employees201Work { get; set; }
        public virtual DbSet<EmployeesRecurring> EmployeesRecurring { get; set; }
        public virtual DbSet<FormsDesigner> FormsDesigner { get; set; }
        public virtual DbSet<HolidayTable> HolidayTable { get; set; }
        public virtual DbSet<HolidayTableOthers> HolidayTableOthers { get; set; }
        public virtual DbSet<LeaveFile> LeaveFile { get; set; }
        public virtual DbSet<LeaveFileHeader> LeaveFileHeader { get; set; }
        public virtual DbSet<LeaveTable> LeaveTable { get; set; }
        public virtual DbSet<LoanCashPayment> LoanCashPayment { get; set; }
        public virtual DbSet<LoanFile> LoanFile { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<OtherHolidays> OtherHolidays { get; set; }
        public virtual DbSet<OvertimeTable> OvertimeTable { get; set; }
        public virtual DbSet<Pagibigtable> Pagibigtable { get; set; }
        public virtual DbSet<PayrollDetails> PayrollDetails { get; set; }
        public virtual DbSet<PayrollEntry> PayrollEntry { get; set; }
        public virtual DbSet<PayrollHeader> PayrollHeader { get; set; }
        public virtual DbSet<PayrollPeriod> PayrollPeriod { get; set; }
        public virtual DbSet<PayrollRegsCode> PayrollRegsCode { get; set; }
        public virtual DbSet<PayrollTrans01> PayrollTrans01 { get; set; }
        public virtual DbSet<PayrollTrans02> PayrollTrans02 { get; set; }
        public virtual DbSet<Peraatable> Peraatable { get; set; }
        public virtual DbSet<PerformanceTable> PerformanceTable { get; set; }
        public virtual DbSet<PhilHealthTable> PhilHealthTable { get; set; }
        public virtual DbSet<PreviousEmployer> PreviousEmployer { get; set; }
        public virtual DbSet<ProdDetails> ProdDetails { get; set; }
        public virtual DbSet<ProdHeader> ProdHeader { get; set; }
        public virtual DbSet<ProdOutput> ProdOutput { get; set; }
        public virtual DbSet<ProdOutputHeader> ProdOutputHeader { get; set; }
        public virtual DbSet<ProjectsTable> ProjectsTable { get; set; }
        public virtual DbSet<RptBonus> RptBonus { get; set; }
        public virtual DbSet<RptContriSummary> RptContriSummary { get; set; }
        public virtual DbSet<RptPayrollAllocation> RptPayrollAllocation { get; set; }
        public virtual DbSet<RptSlvl> RptSlvl { get; set; }
        public virtual DbSet<SalaryAdjustment> SalaryAdjustment { get; set; }
        public virtual DbSet<Salesman> Salesman { get; set; }
        public virtual DbSet<Sbrtable> Sbrtable { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleBreaktimeCalendar> ScheduleBreaktimeCalendar { get; set; }
        public virtual DbSet<ScheduleCalendarDept> ScheduleCalendarDept { get; set; }
        public virtual DbSet<ScheduleCalendarEmp> ScheduleCalendarEmp { get; set; }
        public virtual DbSet<ScheduleEmpBreakTime> ScheduleEmpBreakTime { get; set; }
        public virtual DbSet<Slvlbracket> Slvlbracket { get; set; }
        public virtual DbSet<Slvltable> Slvltable { get; set; }
        public virtual DbSet<Ssscertification> Ssscertification { get; set; }
        public virtual DbSet<Ssstable> Ssstable { get; set; }
        public virtual DbSet<SysVariables> SysVariables { get; set; }
        public virtual DbSet<TardinessTable> TardinessTable { get; set; }
        public virtual DbSet<TaxStatus> TaxStatus { get; set; }
        public virtual DbSet<TaxStatusPrev> TaxStatusPrev { get; set; }
        public virtual DbSet<TaxableLeaves> TaxableLeaves { get; set; }
        public virtual DbSet<UndertimeTable> UndertimeTable { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }
        public virtual DbSet<UserRights2> UserRights2 { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VoucherAccount> VoucherAccount { get; set; }
        public virtual DbSet<VoucherDetails> VoucherDetails { get; set; }
        public virtual DbSet<VoucherHeader> VoucherHeader { get; set; }

        // Unable to generate entity type for table 'dbo.UserLogs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PerformanceData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RateFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PerformanceDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptSalaryMemo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserRights'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RegistrationInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BIRAlphaList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptMSSactionTardiness'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptMonthlyChartTS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReportPrinter'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PayrollRpt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.usr_Branches'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rparams'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptTardinessMemo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptDailyAbsences'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ATMReport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alphalist73'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MonthlySummary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptDailyAttendance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BackupHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BIR1601C'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptPAGIBIGM1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptSSSR1A'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CustomReport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WeeklySummary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contract'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptSSSR3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DailyInOut'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alphalist71'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PayslipTwo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MonthlySummaryTS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptUnionSSSMCL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MSSickLeaveReport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SSSLoanRpt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SSSCollectionList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CustomPYRegisterRPT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BIR2316'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeaveFileData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LeaveFileDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alphalist74'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptPaySlip'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JEHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SSSR3List'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptSLVLGenerate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.JVHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptMSSanctionTardiness'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SanctionsTardiness'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptWSTardiness'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptWSSickLeave'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptMSTardiness'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptMSSickLeave'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EmployeePromotion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptRF1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptPhilHealthEr2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SysLevel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EmployeesCustomPY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Denomination'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alphalist75'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.13MonthDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.13MonthData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DeviceTable'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=DESIPAYROLL;user id=sa;password=B1Admin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AccountCode>(entity =>
            {
                entity.HasKey(e => e.AccountCode1)
                    .HasName("PK__AccountC__38D0C56BFEE83CAC");

                entity.Property(e => e.AccountCode1)
                    .HasColumnName("AccountCode")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountDesc)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Deminimis)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Include13th)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsHealth)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NonTaxable)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PayrollRegCode).HasMaxLength(25);

                entity.Property(e => e.PercentDaily).HasDefaultValueSql("((0))");

                entity.Property(e => e.PercentMonthly).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AnnualTaxTable>(entity =>
            {
                entity.HasKey(e => e.Excess)
                    .HasName("PK__AnnualTa__BCFD235F7E00B8B0");

                entity.Property(e => e.Excess).HasColumnType("money");

                entity.Property(e => e.Base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<BonusDetails>(entity =>
            {
                entity.HasKey(e => new { e.TransYear, e.BonusType, e.EmployeeNo })
                    .HasName("PK__BonusDet__12EF66823ED090BB");

                entity.Property(e => e.TransYear).HasMaxLength(4);

                entity.Property(e => e.BonusType).HasMaxLength(2);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputationType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PercentRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Wtax)
                    .HasColumnName("WTax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BonusHeader>(entity =>
            {
                entity.HasKey(e => new { e.TransYear, e.BonusType })
                    .HasName("PK__BonusHea__A595B6734973BF3B");

                entity.Property(e => e.TransYear).HasMaxLength(4);

                entity.Property(e => e.BonusType).HasMaxLength(2);

                entity.Property(e => e.IncludeMonth01)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludeMonth02)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludeMonth03)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludePagIbig)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePhealth)
                    .HasColumnName("IncludePHealth")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeSss)
                    .HasColumnName("IncludeSSS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PayrollPeriod1).HasMaxLength(9);

                entity.Property(e => e.PayrollPeriod2).HasMaxLength(9);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<BonusLocker>(entity =>
            {
                entity.HasKey(e => new { e.MonthCode, e.BonusType })
                    .HasName("PK__BonusLoc__FC1299337332798E");

                entity.Property(e => e.MonthCode).HasMaxLength(7);

                entity.Property(e => e.BonusType).HasMaxLength(1);

                entity.Property(e => e.IsLocked)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<BonusPerfDetails>(entity =>
            {
                entity.HasKey(e => new { e.MonthCode, e.EmployeeNo })
                    .HasName("PK__BonusPer__F574270A8B941087");

                entity.Property(e => e.MonthCode).HasMaxLength(7);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputationType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PercentRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Wtax)
                    .HasColumnName("WTax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BonusPerfHeader>(entity =>
            {
                entity.HasKey(e => e.MonthCode)
                    .HasName("PK__BonusPer__82D9281190DAAF84");

                entity.Property(e => e.MonthCode)
                    .HasMaxLength(7)
                    .ValueGeneratedNever();

                entity.Property(e => e.IncludeMonth01)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludeMonth02)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludeMonth03)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludePagIbig)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePhealth)
                    .HasColumnName("IncludePHealth")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeSss)
                    .HasColumnName("IncludeSSS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PayrollPeriod1).HasMaxLength(9);

                entity.Property(e => e.PayrollPeriod2).HasMaxLength(9);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK__Companie__11A0134A8379C5B1");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyAddress1)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DbaseName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DbasePath)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagIbigNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhilHealthNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PictureFolder)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sssno)
                    .HasColumnName("SSSNo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxIdno)
                    .HasColumnName("TaxIDNo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateFolder)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomPyregister>(entity =>
            {
                entity.HasKey(e => e.ReportNo)
                    .HasName("PK__CustomPY__D5BE74AAC86A7D5B");

                entity.ToTable("CustomPYRegister");

                entity.Property(e => e.ReportNo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BottomMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.LeftMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orientation).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaperType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaperWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RightMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.TopMargin).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CustomPyregisterAcct>(entity =>
            {
                entity.HasKey(e => new { e.ReportNo, e.SeqNo, e.AccountCode })
                    .HasName("PK__CustomPY__78291B27869C7DBB");

                entity.ToTable("CustomPYRegisterAcct");

                entity.Property(e => e.ReportNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<CustomPyregsDtl>(entity =>
            {
                entity.HasKey(e => new { e.ReportNo, e.SeqNo })
                    .HasName("PK__CustomPY__1211CBE267F99FD4");

                entity.ToTable("CustomPYRegsDtl");

                entity.Property(e => e.ReportNo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ColumType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DispValue)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HideZero).HasMaxLength(1);

                entity.Property(e => e.IsVisible).HasMaxLength(1);

                entity.Property(e => e.WithSeparator).HasMaxLength(1);

                entity.HasOne(d => d.ReportNoNavigation)
                    .WithMany(p => p.CustomPyregsDtl)
                    .HasForeignKey(d => d.ReportNo)
                    .HasConstraintName("FK__CustomPYR__Repor__4321E620");
            });

            modelBuilder.Entity<CustomPysetup>(entity =>
            {
                entity.HasKey(e => e.CustomPycode)
                    .HasName("PK__CustomPY__D0BE2650506D64B9");

                entity.ToTable("CustomPYSetup");

                entity.Property(e => e.CustomPycode)
                    .HasColumnName("CustomPYCode")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomPydesc)
                    .HasColumnName("CustomPYDesc")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FixPagIbigEmployee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixPagIbigEmployer)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixPeraaemployee)
                    .HasColumnName("FixPERAAEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixPeraaemployer)
                    .HasColumnName("FixPERAAEmployer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixPhealthEmployee)
                    .HasColumnName("FixPHealthEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixPhealthEmployer)
                    .HasColumnName("FixPHealthEmployer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixSssec)
                    .HasColumnName("FixSSSEC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixSssemployee)
                    .HasColumnName("FixSSSEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixSssemployer)
                    .HasColumnName("FixSSSEmployer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludePagIbigCola)
                    .HasColumnName("IncludePagIbigCOLA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePagIbigLeaves)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePeraaCola)
                    .HasColumnName("IncludePeraaCOLA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePeraaLeaves)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePhealthCola)
                    .HasColumnName("IncludePHealthCOLA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePhealthLeaves)
                    .HasColumnName("IncludePHealthLeaves")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeSsscola)
                    .HasColumnName("IncludeSSSCOLA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeSssleaves)
                    .HasColumnName("IncludeSSSLeaves")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeTaxCola)
                    .HasColumnName("IncludeTaxCOLA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeTaxLeaves)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigBaseAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigBaseCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigBasePercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigMaximum)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule01)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule02)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule03)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule04)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule05)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSchedule06)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PagIbigSubsidy)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PeraabaseAmount)
                    .HasColumnName("PERAABaseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PeraabaseCode)
                    .HasColumnName("PERAABaseCode")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PeraabasePercent)
                    .HasColumnName("PERAABasePercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peraaoption)
                    .HasColumnName("PERAAOption")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule01)
                    .HasColumnName("PERAASchedule01")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule02)
                    .HasColumnName("PERAASchedule02")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule03)
                    .HasColumnName("PERAASchedule03")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule04)
                    .HasColumnName("PERAASchedule04")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule05)
                    .HasColumnName("PERAASchedule05")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Peraaschedule06)
                    .HasColumnName("PERAASchedule06")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthBaseAmount)
                    .HasColumnName("PHealthBaseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhealthBaseCode)
                    .HasColumnName("PHealthBaseCode")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthBasePercent)
                    .HasColumnName("PHealthBasePercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhealthSchedule01)
                    .HasColumnName("PHealthSchedule01")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthSchedule02)
                    .HasColumnName("PHealthSchedule02")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthSchedule03)
                    .HasColumnName("PHealthSchedule03")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthSchedule04)
                    .HasColumnName("PHealthSchedule04")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthSchedule05)
                    .HasColumnName("PHealthSchedule05")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhealthSchedule06)
                    .HasColumnName("PHealthSchedule06")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RateDivisor).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerHourDivisor).HasDefaultValueSql("((0))");

                entity.Property(e => e.SssbaseAmount)
                    .HasColumnName("SSSBaseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SssbaseCode)
                    .HasColumnName("SSSBaseCode")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SssbasePercent)
                    .HasColumnName("SSSBasePercent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssschedule01)
                    .HasColumnName("SSSSchedule01")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sssschedule02)
                    .HasColumnName("SSSSchedule02")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sssschedule03)
                    .HasColumnName("SSSSchedule03")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sssschedule04)
                    .HasColumnName("SSSSchedule04")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sssschedule05)
                    .HasColumnName("SSSSchedule05")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sssschedule06)
                    .HasColumnName("SSSSchedule06")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxBaseAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxBaseCode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxBasePercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxMonthEnd)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxSchedule01)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxSchedule02)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxSchedule03)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxSchedule04)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxSchedule05)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxSchedule06)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<DailyOtauth>(entity =>
            {
                entity.HasKey(e => new { e.TransDate, e.EmployeeNo, e.IsType })
                    .HasName("PK__DailyOTA__F5AD6730F469033B");

                entity.ToTable("DailyOTAuth");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsType).HasMaxLength(1);

                entity.Property(e => e.NoOfHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfMins).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DailyTimeDetails>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransDate })
                    .HasName("PK__DailyTim__DFAD35A9DD877670");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.Absences).HasDefaultValueSql("((0))");

                entity.Property(e => e.AbsencesMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedEarlyOthrs)
                    .HasColumnName("ApprovedEarlyOTHrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedEarlyOtmins)
                    .HasColumnName("ApprovedEarlyOTMins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedNdiffOthrs)
                    .HasColumnName("ApprovedNDiffOTHrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedNdiffOtmins)
                    .HasColumnName("ApprovedNDiffOTMins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedOt)
                    .HasColumnName("ApprovedOT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovedOtmins)
                    .HasColumnName("ApprovedOTMins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseRegularHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseRegularMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.ConfirmAtt).HasMaxLength(1);

                entity.Property(e => e.DeductibleAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DispTimeIn)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DispTimeOut)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EarlyOthrs)
                    .HasColumnName("EarlyOTHrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EarlyOtmins)
                    .HasColumnName("EarlyOTMins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcessMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.Holiday).HasDefaultValueSql("((0))");

                entity.Property(e => e.HolidayMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.InOutStatus)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LeaveCode).HasMaxLength(2);

                entity.Property(e => e.NextDayTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NightDiff).HasDefaultValueSql("((0))");

                entity.Property(e => e.NightDiffMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.NightDiffOt)
                    .HasColumnName("NightDiffOT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightDiffOtmins)
                    .HasColumnName("NightDiffOTMins")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherDeduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherDeductionMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaternityLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaternityLeaveMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectCode).HasMaxLength(20);

                entity.Property(e => e.RegularHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegularMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickLeaveMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tardiness).HasDefaultValueSql("((0))");

                entity.Property(e => e.TardinessMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.UnderApproved).HasMaxLength(1);

                entity.Property(e => e.VacationLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationLeaveMins).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DailyTimeHeader>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo })
                    .HasName("PK__DailyTim__4D06FAE410B5E1DF");

                entity.Property(e => e.PayrollPeriod).HasMaxLength(9);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);
            });

            modelBuilder.Entity<DailyTrans>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransType, e.TransDate, e.TransTime })
                    .HasName("PK__DailyTra__3D2C03AEDA4B10AF");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.TransType02)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DateLocker>(entity =>
            {
                entity.HasKey(e => e.TransDate)
                    .HasName("PK__DateLock__57DC41FB403BA6C6");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.IsLocked)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentCode)
                    .HasName("PK__Departme__6EA8896C55661078");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentDesc)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DeviceList>(entity =>
            {
                entity.HasKey(e => e.TerminalId)
                    .HasName("PK__DeviceLi__6A72634971BFF63F");

                entity.Property(e => e.TerminalId)
                    .HasColumnName("TerminalID")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(350);

                entity.Property(e => e.Disabled).HasMaxLength(1);

                entity.Property(e => e.InTpe).HasMaxLength(1);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.OutTpe).HasMaxLength(1);

                entity.Property(e => e.Status).HasMaxLength(1);
            });

            modelBuilder.Entity<EmployeeDependents>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.DependentName })
                    .HasName("PK__Employee__AA7075EF7AEE77D8");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DependentName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DependentBirthday).HasColumnType("datetime");

                entity.Property(e => e.DependentType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmployeeEducation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__Employee__7AD0F1B6E88D7D36");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.College)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollegeDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollegeSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ElemDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ElemSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Elementary)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Others)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OthersDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OthersSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostGrad)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Secondary)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VocaDateGrad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VocaSchool)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vocational)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmployeeEducationNew>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.SchoolName, e.CourseDesc })
                    .HasName("PK__Employee__8574895CE329E842");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CourseDesc)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchoolAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.YearGraduated)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeEducationNew)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__EmployeeE__Emplo__44160A59");
            });

            modelBuilder.Entity<EmployeeHoliday>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.HolidayCode })
                    .HasName("PK__Employee__0F8AD0DB697C0902");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HolidayCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDate02).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeProjects>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.DateFrom, e.DateTo })
                    .HasName("PK__Employee__A7784DCED08DFD53");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__EmployeeP__Emplo__450A2E92");
            });

            modelBuilder.Entity<EmployeeSchedule>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.DateFrom })
                    .HasName("PK__Employee__DEDC6BEBA059F60D");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.IsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RestDay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ScheduleCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WithOvertime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithTardiness)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeSchedule)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__EmployeeS__Emplo__47E69B3D");
            });

            modelBuilder.Entity<EmployeeSlvl>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.EffectivityFrom })
                    .HasName("PK__Employee__0D265A5EBA167539");

                entity.ToTable("EmployeeSLVL");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EffectivityFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectivityTo).HasColumnType("datetime");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sick).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickCon).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickGen).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickUsed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Slconverted)
                    .HasColumnName("SLConverted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransYear)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vacation).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationCon).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationGen).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationUsed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vlconverted)
                    .HasColumnName("VLConverted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeSlvl)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__EmployeeS__Emplo__49CEE3AF");
            });

            modelBuilder.Entity<EmployeeSlvldetails>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransDate, e.LeaveType })
                    .HasName("PK__Employee__4C1970ACA6029A9E");

                entity.ToTable("EmployeeSLVLDetails");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NoOfHours).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeSlvldetails)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__EmployeeS__Emplo__4AC307E8");
            });

            modelBuilder.Entity<EmployeeTaxStatus>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TaxStatDate, e.TaxStatus })
                    .HasName("PK__Employee__62963FFA50F5C24A");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxStatDate).HasColumnType("datetime");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeeTaxStatus)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK_EmployeeTaxStatus_Employees");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__Employee__7AD0F1B62EA5602D");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address01)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address02)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AsBranchCode).HasMaxLength(20);

                entity.Property(e => e.AttendanceExempt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillingRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Category)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CivilStatus)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Colaamount)
                    .HasColumnName("COLAAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConfiLevel)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CustomPycode)
                    .HasColumnName("CustomPYCode")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DailyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DailyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateFinish).HasColumnType("datetime");

                entity.Property(e => e.DateHired).HasColumnType("datetime");

                entity.Property(e => e.DateOfClearance).HasColumnType("datetime");

                entity.Property(e => e.DateRegular).HasColumnType("datetime");

                entity.Property(e => e.DaysOfYear).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepCode).HasMaxLength(50);

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DftLeaveCredit)
                    .HasColumnName("dftLeaveCredit")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.EmpPosition)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpStatus)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.GracePeriod).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeGracePeriod)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxTardiness).HasDefaultValueSql("((0))");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthlyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthlyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayrollMode)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayrollTerms)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Peraano)
                    .HasColumnName("PERAANo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhilHealthNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RateDivisor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.RestDay)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SchedAllow)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SchedPass)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ScheduleCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slvlcode)
                    .HasColumnName("SLVLCode")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sssno)
                    .HasColumnName("SSSNo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SuffixName)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TardySetup)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TaxEnd).HasMaxLength(9);

                entity.Property(e => e.TaxIdno)
                    .HasColumnName("TaxIDNo")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxStart).HasMaxLength(9);

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telephone01)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telephone02)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TerminationStatus).HasMaxLength(250);

                entity.Property(e => e.TimeKeepingId)
                    .HasColumnName("TimeKeepingID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimekeepingAbsHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimekeepingAbsMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseTardyTable)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WithOvertime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithPagibig)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithPeraa)
                    .HasColumnName("WithPERAA")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WithPhilHealth)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithSss)
                    .HasColumnName("WithSSS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithTardiness)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithTin)
                    .HasColumnName("WithTIN")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WithUndertime)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK__Employees__Depar__45FE52CB");
            });

            modelBuilder.Entity<Employees201>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Date201, e.Particular, e.SanctionType })
                    .HasName("PK__Employee__B030E0A88933781A");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Date201).HasColumnType("datetime");

                entity.Property(e => e.Particular)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SanctionType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.Employees201)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__Employees__Emplo__46F27704");
            });

            modelBuilder.Entity<Employees201Award>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Award, e.Institution, e.GivenDate })
                    .HasName("PK__Employee__1BD2751A4D6C41B7");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Award)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GivenDate).HasColumnType("datetime");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Dependents>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.DependentName })
                    .HasName("PK__Employee__AA7075EF13CEA405");

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.DependentName).HasMaxLength(100);

                entity.Property(e => e.DependentBirthday).HasColumnType("datetime");

                entity.Property(e => e.DependentType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Employees201Education>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.EduLevel, e.School, e.Degree })
                    .HasName("PK__Employee__539E29FCB73AF25C");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EduLevel)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.School)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Degree)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EduFrom).HasColumnType("datetime");

                entity.Property(e => e.EduTo).HasColumnType("datetime");

                entity.Property(e => e.Honors)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201ExamTaken>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Code })
                    .HasName("PK__Employee__00F5341C5C4B9934");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateExam).HasColumnType("datetime");

                entity.Property(e => e.DateRelease).HasColumnType("datetime");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Header>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__Employee__7AD0F1B63A16F92B");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Employees201Legal>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.CaseNo })
                    .HasName("PK__Employee__1C1A1B1488108781");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CaseStatus)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CourtFiled)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateFiled).HasColumnType("datetime");

                entity.Property(e => e.Detail1)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Detail2)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Prosecutor)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201License>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.LicenseType })
                    .HasName("PK__Employee__1067FAC8F70AE4BF");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.ExamPlace)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employees201Medical>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.MedicalNo })
                    .HasName("PK__Employee__0E0D42C68F9BC811");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MedicalNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Detail1)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Detail2)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Findings1)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Findings2)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MedicalDate).HasColumnType("datetime");

                entity.Property(e => e.Physician)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Venue)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Memo>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransDate, e.MemoFrom, e.MemoTo, e.MemoType })
                    .HasName("PK__Employee__2E461B0ECCBD5EB5");

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.MemoFrom).HasColumnType("datetime");

                entity.Property(e => e.MemoTo).HasColumnType("datetime");

                entity.Property(e => e.MemoType).HasMaxLength(1);

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Particulars).HasMaxLength(200);
            });

            modelBuilder.Entity<Employees201Organization>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.OrgName })
                    .HasName("PK__Employee__270793524BAA440B");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OrgFrom).HasColumnType("datetime");

                entity.Property(e => e.OrgTo).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Relative>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Lname, e.Fname })
                    .HasName("PK__Employee__24DFDE48BB1463D4");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mname)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Relative)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Reminders>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransDate, e.ReminderDate, e.Particulars })
                    .HasName("PK__Employee__8CDB4E3F13ED92B3");

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.Property(e => e.Particulars).HasMaxLength(300);

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Employees201Skill>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.EmpSkill })
                    .HasName("PK__Employee__2362D8F13266FAE7");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpSkill)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpLevel)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Training>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Training, e.Institution })
                    .HasName("PK__Employee__31318FD98FA1FE4E");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Training)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Conductor)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TrainFrom).HasColumnType("datetime");

                entity.Property(e => e.TrainTo).HasColumnType("datetime");

                entity.Property(e => e.Venue)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Employees201Work>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.Company, e.Position, e.WorkFrom })
                    .HasName("PK__Employee__1C61B91F4A9CF455");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WorkFrom).HasColumnType("datetime");

                entity.Property(e => e.DocFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Separation)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WorkStatus)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WorkTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeesRecurring>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.AccountCode, e.Freq })
                    .HasName("PK__Employee__C76F4C72C4CA3EA3");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Freq)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.EmployeeNoNavigation)
                    .WithMany(p => p.EmployeesRecurring)
                    .HasForeignKey(d => d.EmployeeNo)
                    .HasConstraintName("FK__Employees__Emplo__4BB72C21");
            });

            modelBuilder.Entity<FormsDesigner>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Description })
                    .HasName("PK__FormsDes__36B7E10A67F59162");

                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HolidayTable>(entity =>
            {
                entity.HasKey(e => e.HolidayCode)
                    .HasName("PK__HolidayT__55A216D6D448C424");

                entity.Property(e => e.HolidayCode)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDate02).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HolidayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NoOfHolidays).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HolidayTableOthers>(entity =>
            {
                entity.HasKey(e => new { e.TransDate, e.HolidayType })
                    .HasName("PK__HolidayT__216CA0FBF27B7616");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.HolidayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.HolidayDesc)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LeaveFile>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.DateFrom })
                    .HasName("PK__LeaveFil__DEDC6BEBCC1B176C");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.LeaveCode)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Remarks)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LeaveFileHeader>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__LeaveFil__7AD0F1B6948483F8");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<LeaveTable>(entity =>
            {
                entity.HasKey(e => e.LeaveCode)
                    .HasName("PK__LeaveTab__04AB2D71D6315E13");

                entity.Property(e => e.LeaveCode)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveDesc)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LoanCashPayment>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.AccountCode, e.LoanRefNo, e.Orno })
                    .HasName("PK__LoanCash__BCDFE2CC7EF3F415");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoanRefNo)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Orno)
                    .HasColumnName("ORNo")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PayrollPeriod).HasMaxLength(15);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoanFile>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.AccountCode, e.LoanRefNo })
                    .HasName("PK__LoanFile__F4157844186FFF72");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoanRefNo)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amortization)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmountGranted)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateInActive).HasColumnType("datetime");

                entity.Property(e => e.DownPayment).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FirstDueDate).HasColumnType("datetime");

                entity.Property(e => e.LastPayment)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lcpprice)
                    .HasColumnName("LCPPrice")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.LoanAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoanDate).HasColumnType("datetime");

                entity.Property(e => e.LoanInterest).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.MonthlyDueDate).HasColumnType("datetime");

                entity.Property(e => e.OrigBcode)
                    .HasColumnName("OrigBCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OrigBname)
                    .HasColumnName("OrigBName")
                    .HasMaxLength(250);

                entity.Property(e => e.Particular).HasMaxLength(250);

                entity.Property(e => e.Rebate).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.RebateApplication).HasMaxLength(5);

                entity.Property(e => e.RelativeName).HasMaxLength(50);

                entity.Property(e => e.Saparcount)
                    .HasColumnName("SAPARCount")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Sapbpcode)
                    .HasColumnName("SAPBPCode")
                    .HasMaxLength(30);

                entity.Property(e => e.SapdocEntry)
                    .HasColumnName("SAPDocEntry")
                    .HasMaxLength(30);

                entity.Property(e => e.Saperror)
                    .HasColumnName("SAPError")
                    .HasMaxLength(250);

                entity.Property(e => e.SpotCashAmount).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.StartOfDeduction)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TempTotalCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Terms).HasMaxLength(50);

                entity.Property(e => e.TermsOfPayment)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalCash).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCredit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPayroll).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<OtherHolidays>(entity =>
            {
                entity.HasKey(e => new { e.TransDate, e.EmployeeNo })
                    .HasName("PK__OtherHol__20714EE0D0493BB6");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.CheckDate1).HasColumnType("datetime");

                entity.Property(e => e.CheckDate2).HasColumnType("datetime");

                entity.Property(e => e.HolidayType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<OvertimeTable>(entity =>
            {
                entity.HasKey(e => new { e.MinutesFrom, e.MinutesTo })
                    .HasName("PK__Overtime__A675AAE3159B7667");

                entity.Property(e => e.Deduction).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Pagibigtable>(entity =>
            {
                entity.HasKey(e => e.IncomeBracket)
                    .HasName("PK__PAGIBIGT__540F9C2A1242B267");

                entity.ToTable("PAGIBIGTable");

                entity.Property(e => e.IncomeBracket).HasColumnType("money");

                entity.Property(e => e.Employee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Employer).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxContribution)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PayrollDetails>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo, e.AccountCode, e.LoanRefenceNo })
                    .HasName("PK__PayrollD__653AB15729DF52E9");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoanRefenceNo)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.DateUploaded).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.NoOfHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.SapdocNumber)
                    .HasColumnName("SAPDocNumber")
                    .HasMaxLength(30);

                entity.Property(e => e.Saperror)
                    .HasColumnName("SAPError")
                    .HasMaxLength(250);

                entity.Property(e => e.SapinsDate)
                    .HasColumnName("SAPInsDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapinsId)
                    .HasColumnName("SAPInsID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.TotalDays).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalHrs).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Uploaded).HasMaxLength(5);
            });

            modelBuilder.Entity<PayrollEntry>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo })
                    .HasName("PK__PayrollE__4D06FAE434C03F64");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PayrollHeader>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo })
                    .HasName("PK__PayrollH__4D06FAE4F2BBC891");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BasicPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.CalamityLoan).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Colaamount)
                    .HasColumnName("COLAAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DailyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deminimis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Gross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HazardPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HealthInsurance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HolidayPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMwe)
                    .HasColumnName("IsMWE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Leghrs)
                    .HasColumnName("LEGHrs")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Legpay)
                    .HasColumnName("LEGPay")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Month13th)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthlyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NightDiffPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NonTaxPagIbig)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NonTaxable)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCompen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherDeduction)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherIncome)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherLoan).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Othrs)
                    .HasColumnName("OTHrs")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Otpay)
                    .HasColumnName("OTPay")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OvertimePay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigBaseAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigEmployee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigEmployer)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagibigLoan).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.PayrollMode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayrollType).HasMaxLength(20);

                entity.Property(e => e.PeraabaseAmount)
                    .HasColumnName("PERAABaseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peraaemployee)
                    .HasColumnName("PERAAEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peraaemployer)
                    .HasColumnName("PERAAEmployer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhilHealthBaseAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhilHealthEmployee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhilHealthEmployer)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Splhrs)
                    .HasColumnName("SPLHrs")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Splpay)
                    .HasColumnName("SPLPay")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.SssbaseAmount)
                    .HasColumnName("SSSBaseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssec)
                    .HasColumnName("SSSEC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssemployee)
                    .HasColumnName("SSSEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssemployer)
                    .HasColumnName("SSSEmployer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssloan)
                    .HasColumnName("SSSLoan")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sunhrs)
                    .HasColumnName("SUNHrs")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.Sunpay)
                    .HasColumnName("SUNPay")
                    .HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TaxBaseAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDays).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalDeductions)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHrs).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.UnionDues)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Validated).HasMaxLength(5);

                entity.Property(e => e.WithTin)
                    .HasColumnName("WithTIN")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WitholdingTax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PayrollPeriod>(entity =>
            {
                entity.HasKey(e => e.PayrollPeriod1)
                    .HasName("PK__PayrollP__3AABF5FF5E64AA44");

                entity.Property(e => e.PayrollPeriod1)
                    .HasColumnName("PayrollPeriod")
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateOne).HasColumnType("datetime");

                entity.Property(e => e.DateTwo).HasColumnType("datetime");

                entity.Property(e => e.IsLocked)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<PayrollRegsCode>(entity =>
            {
                entity.HasKey(e => e.AccountCode)
                    .HasName("PK__PayrollR__38D0C56B461078C0");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PayrollTrans01>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo, e.AccountCode })
                    .HasName("PK__PayrollT__273E2A21BA4D8E45");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoOfHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoOfMins).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.TotalDays).HasColumnType("numeric(19, 6)");

                entity.Property(e => e.TotalHrs).HasColumnType("numeric(19, 6)");
            });

            modelBuilder.Entity<PayrollTrans02>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo, e.AccountCode })
                    .HasName("PK__PayrollT__273E2A21E6AD5869");

                entity.Property(e => e.PayrollPeriod)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(250);
            });

            modelBuilder.Entity<Peraatable>(entity =>
            {
                entity.HasKey(e => e.IncomeBracket)
                    .HasName("PK__PERAATab__540F9C2A122453A4");

                entity.ToTable("PERAATable");

                entity.Property(e => e.IncomeBracket).HasColumnType("money");

                entity.Property(e => e.Employee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Employer).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PerformanceTable>(entity =>
            {
                entity.HasKey(e => new { e.PercentFrom, e.PercentTo })
                    .HasName("PK__Performa__41677FEC21CEC0E2");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PhilHealthTable>(entity =>
            {
                entity.HasKey(e => e.BracketFrom)
                    .HasName("PK__PhilHeal__5B355D26E3B7706F");

                entity.Property(e => e.BracketFrom).HasColumnType("money");

                entity.Property(e => e.Base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BracketNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.BracketTo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Employee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Employer)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<PreviousEmployer>(entity =>
            {
                entity.HasKey(e => new { e.AppYear, e.EmployeeNo })
                    .HasName("PK__Previous__71D84820C1A10302");

                entity.Property(e => e.AppYear)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr113th)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Address)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr1Basic)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Deminimis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Gross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Hazard)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1HealthInsurance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Holiday)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1IsMwe)
                    .HasColumnName("Empyr1IsMWE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Empyr1NightDiff)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1NonTaxable)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1OtherIncome)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Overtime)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Pgi)
                    .HasColumnName("Empyr1PGI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Phi)
                    .HasColumnName("Empyr1PHI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Sss)
                    .HasColumnName("Empyr1SSS")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Tax)
                    .HasColumnName("Empyr1TAX")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr1Tin)
                    .HasColumnName("Empyr1TIN")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr1Union)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr213th)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Address)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr2Basic)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Deminimis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Gross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Hazard)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2HealthInsurance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Holiday)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2IsMwe)
                    .HasColumnName("Empyr2IsMWE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Empyr2NightDiff)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2NonTaxable)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2OtherIncome)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Overtime)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Pgi)
                    .HasColumnName("Empyr2PGI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Phi)
                    .HasColumnName("Empyr2PHI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Sss)
                    .HasColumnName("Empyr2SSS")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Tax)
                    .HasColumnName("Empyr2TAX")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr2Tin)
                    .HasColumnName("Empyr2TIN")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr2Union)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr313th)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Address)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr3Basic)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Deminimis)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Gross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Hazard)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3HealthInsurance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Holiday)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3IsMwe)
                    .HasColumnName("Empyr3IsMWE")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Empyr3NightDiff)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3NonTaxable)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3OtherIncome)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Overtime)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Pgi)
                    .HasColumnName("Empyr3PGI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Phi)
                    .HasColumnName("Empyr3PHI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Sss)
                    .HasColumnName("Empyr3SSS")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Tax)
                    .HasColumnName("Empyr3TAX")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empyr3Tin)
                    .HasColumnName("Empyr3TIN")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Empyr3Union)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpyrName1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpyrName2)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpyrName3)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ProdDetails>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.OperationNo })
                    .HasName("PK__ProdDeta__AF2A31F31453827E");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperationDesc)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PieceRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Unit)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.ProdDetails)
                    .HasForeignKey(d => d.JobNo)
                    .HasConstraintName("FK__ProdDetai__JobNo__4D9F7493");
            });

            modelBuilder.Entity<ProdHeader>(entity =>
            {
                entity.HasKey(e => e.JobNo)
                    .HasName("PK__ProdHead__056568B1B70B8ABE");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<ProdOutput>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.TransDate, e.JobNo, e.OperationNo })
                    .HasName("PK__ProdOutp__2D021F986D3FB8F7");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProdOutputHeader>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo })
                    .HasName("PK__ProdOutp__4D06FAE4FFFAAD30");

                entity.Property(e => e.PayrollPeriod).HasMaxLength(9);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);
            });

            modelBuilder.Entity<ProjectsTable>(entity =>
            {
                entity.HasKey(e => e.ProjectCode)
                    .HasName("PK__Projects__2F3A494990F190B3");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectDesc)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RptBonus>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__rptBonus__7AD0F1B6DA7B4D5D");

                entity.ToTable("rptBonus");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount14th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount15th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount16th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount17th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount18th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount19th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount20th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount21th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount22th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount23th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount24th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount25th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department).HasMaxLength(12);

                entity.Property(e => e.EmployeeName).HasMaxLength(150);

                entity.Property(e => e.Tax14th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax15th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax16th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax17th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax18th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax19th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax20th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax21th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax22th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax23th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax24th).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax25th).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RptContriSummary>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__rptContr__7AD0F1B6D591D34F");

                entity.ToTable("rptContriSummary");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Gross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigEmployee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhilHealthEmployee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssemployee)
                    .HasColumnName("SSSEmployee")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WitholdingTax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RptPayrollAllocation>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.ProjectCode })
                    .HasName("PK__rptPayro__F82355222D0F83E7");

                entity.ToTable("rptPayrollAllocation");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BasicSalary)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PagIbigContri)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.PhealthContri)
                    .HasColumnName("PHealthContri")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionGrade).HasMaxLength(10);

                entity.Property(e => e.Ssscontri)
                    .HasColumnName("SSSContri")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalGross)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSalary)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RptSlvl>(entity =>
            {
                entity.HasKey(e => e.EmployeeNo)
                    .HasName("PK__rptSLVL__7AD0F1B6242E40EE");

                entity.ToTable("rptSLVL");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sick).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SickUnused).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickUsed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vacation).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationUnused).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationUsed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SalaryAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPeriod, e.EmployeeNo })
                    .HasName("PK__SalaryAd__4D06FAE48BAA2EA2");

                entity.Property(e => e.PayrollPeriod).HasMaxLength(9);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.BillingRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurBillingRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurDailyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurDailyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurMonthlyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurMonthlyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurRateDivisor).HasDefaultValueSql("((0))");

                entity.Property(e => e.DailyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DailyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthlyAllowance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthlyRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateDivisor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.HasKey(e => e.SalesmanCode)
                    .HasName("PK__Salesman__B7287792DB00E717");

                entity.Property(e => e.SalesmanCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConfiLevel)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Department)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FullName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsSalesman)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.LastChange).HasColumnType("datetime");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Locked)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MenuSubItems)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NextAvailable)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.NoChange)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoExpire)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherName)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuotationLocation)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UserLevel)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserPword)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsrInfo)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Sbrtable>(entity =>
            {
                entity.HasKey(e => e.MonthCode)
                    .HasName("PK__SBRTable__82D9281155B847AF");

                entity.ToTable("SBRTable");

                entity.Property(e => e.MonthCode)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpCont).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployerId)
                    .HasColumnName("EmployerID")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Month12)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthDesc)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagIbig)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagIbigDate).HasColumnType("datetime");

                entity.Property(e => e.PagIbigLoan)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagIbigLoanDate).HasColumnType("datetime");

                entity.Property(e => e.PhilHealth)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhilHealthDate).HasColumnType("datetime");

                entity.Property(e => e.SFileName)
                    .HasColumnName("sFileName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignatoryName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignatoryPosition)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sss)
                    .HasColumnName("SSS")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sssamount)
                    .HasColumnName("SSSAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssdate)
                    .HasColumnName("SSSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sssec)
                    .HasColumnName("SSSEC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sssloan)
                    .HasColumnName("SSSLoan")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SssloanDate)
                    .HasColumnName("SSSLoanDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.TransYear).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleCode)
                    .HasName("PK__Schedule__D559BD210F44826B");

                entity.Property(e => e.ScheduleCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Break01In)
                    .HasColumnName("Break01IN")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Break01Out)
                    .HasColumnName("Break01OUT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Break02In)
                    .HasColumnName("Break02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break02Out)
                    .HasColumnName("Break02OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03In)
                    .HasColumnName("Break03IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03Out)
                    .HasColumnName("Break03OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04In)
                    .HasColumnName("Break04IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04Out)
                    .HasColumnName("Break04OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakTime01).HasColumnType("datetime");

                entity.Property(e => e.BreakTime02).HasColumnType("datetime");

                entity.Property(e => e.BreakTimeHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultSched)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Holidays01).HasColumnType("datetime");

                entity.Property(e => e.Holidays02).HasColumnType("datetime");

                entity.Property(e => e.IsB1deduct)
                    .HasColumnName("IsB1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB2deduct)
                    .HasColumnName("IsB2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB3deduct)
                    .HasColumnName("IsB3Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB4deduct)
                    .HasColumnName("IsB4Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMiddeduct)
                    .HasColumnName("IsMIDDeduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsOt1deduct)
                    .HasColumnName("IsOT1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOt2deduct)
                    .HasColumnName("IsOT2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MidBreakHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Otbreak01In)
                    .HasColumnName("OTBreak01IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak01Out)
                    .HasColumnName("OTBreak01OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02In)
                    .HasColumnName("OTBreak02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02Out)
                    .HasColumnName("OTBreak02OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sundays01).HasColumnType("datetime");

                entity.Property(e => e.Sundays02).HasColumnType("datetime");

                entity.Property(e => e.Weekdays01).HasColumnType("datetime");

                entity.Property(e => e.Weekdays02).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScheduleBreaktimeCalendar>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentCode, e.MoYear, e.AppDays, e.IsType })
                    .HasName("PK__Schedule__D48717EA2391A41D");

                entity.Property(e => e.DepartmentCode).HasMaxLength(12);

                entity.Property(e => e.MoYear).HasMaxLength(10);

                entity.Property(e => e.AppDays).HasColumnType("datetime");

                entity.Property(e => e.IsType).HasMaxLength(1);

                entity.Property(e => e.Break01Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break01In)
                    .HasColumnName("Break01IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break01Out)
                    .HasColumnName("Break01OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break02Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break02In)
                    .HasColumnName("Break02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break02Out)
                    .HasColumnName("Break02OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break03In)
                    .HasColumnName("Break03IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03Out)
                    .HasColumnName("Break03OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break04In)
                    .HasColumnName("Break04IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04Out)
                    .HasColumnName("Break04OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsB1deduct)
                    .HasColumnName("IsB1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB2deduct)
                    .HasColumnName("IsB2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB3deduct)
                    .HasColumnName("IsB3Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB4deduct)
                    .HasColumnName("IsB4Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMiddeduct)
                    .HasColumnName("IsMIDDeduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOt1deduct)
                    .HasColumnName("IsOT1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOt2deduct)
                    .HasColumnName("IsOT2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MidBreakHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.MidBreakIn)
                    .HasColumnName("MidBreakIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.MidBreakOut)
                    .HasColumnName("MidBreakOUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak01Hrs)
                    .HasColumnName("OTBreak01Hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otbreak01In)
                    .HasColumnName("OTBreak01IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak01Out)
                    .HasColumnName("OTBreak01OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02Hrs)
                    .HasColumnName("OTBreak02Hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otbreak02In)
                    .HasColumnName("OTBreak02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02Out)
                    .HasColumnName("OTBreak02OUT")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ScheduleCalendarDept)
                    .WithMany(p => p.ScheduleBreaktimeCalendar)
                    .HasForeignKey(d => new { d.DepartmentCode, d.MoYear, d.AppDays })
                    .HasConstraintName("FK__ScheduleBreaktim__4F87BD05");
            });

            modelBuilder.Entity<ScheduleCalendarDept>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentNo, e.MoYear, e.AppDays })
                    .HasName("PK__Schedule__0575FF8D1E46E5E4");

                entity.Property(e => e.DepartmentNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MoYear)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppDays).HasColumnType("datetime");

                entity.Property(e => e.ActualShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CellNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsUpdated)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PatternCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegularHrs)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RestDay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RevIsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RevRestDay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RevShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RevisedTimeIn)
                    .HasColumnName("RevisedTimeIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisedTimeOut)
                    .HasColumnName("RevisedTimeOUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduleSrc)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.TotalBreak)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ScheduleCalendarEmp>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.MoYear, e.AppDays })
                    .HasName("PK__Schedule__CDA2ADADACF42B7D");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MoYear)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppDays).HasColumnType("datetime");

                entity.Property(e => e.ActualShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActualTimeIn)
                    .HasColumnName("ActualTimeIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualTimeOut)
                    .HasColumnName("ActualTimeOUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CellNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsUpdated)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PatternCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegularHrs)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RestDay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RevIsFlexiTime)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RevRestDay)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RevShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RevisedTimeIn)
                    .HasColumnName("RevisedTimeIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisedTimeOut)
                    .HasColumnName("RevisedTimeOUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduleSrc)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShiftCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.TotalBreak)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ScheduleEmpBreakTime>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.MoYear, e.AppDays, e.IsType })
                    .HasName("PK__Schedule__C0FF6F30B3F6AF85");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MoYear)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppDays).HasColumnType("datetime");

                entity.Property(e => e.IsType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Break01Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break01In)
                    .HasColumnName("Break01IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break01Out)
                    .HasColumnName("Break01OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break02Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break02In)
                    .HasColumnName("Break02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break02Out)
                    .HasColumnName("Break02OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break03In)
                    .HasColumnName("Break03IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break03Out)
                    .HasColumnName("Break03OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04Hrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Break04In)
                    .HasColumnName("Break04IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Break04Out)
                    .HasColumnName("Break04OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsB1deduct)
                    .HasColumnName("IsB1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB2deduct)
                    .HasColumnName("IsB2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB3deduct)
                    .HasColumnName("IsB3Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsB4deduct)
                    .HasColumnName("IsB4Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMiddeduct)
                    .HasColumnName("IsMIDDeduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOt1deduct)
                    .HasColumnName("IsOT1Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOt2deduct)
                    .HasColumnName("IsOT2Deduct")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MidBreakHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.MidBreakIn)
                    .HasColumnName("MidBreakIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.MidBreakOut)
                    .HasColumnName("MidBreakOUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak01Hrs)
                    .HasColumnName("OTBreak01Hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otbreak01In)
                    .HasColumnName("OTBreak01IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak01Out)
                    .HasColumnName("OTBreak01OUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02Hrs)
                    .HasColumnName("OTBreak02Hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otbreak02In)
                    .HasColumnName("OTBreak02IN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otbreak02Out)
                    .HasColumnName("OTBreak02OUT")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ScheduleCalendarEmp)
                    .WithMany(p => p.ScheduleEmpBreakTime)
                    .HasForeignKey(d => new { d.EmployeeNo, d.MoYear, d.AppDays })
                    .HasConstraintName("FK__ScheduleEmpBreak__507BE13E");
            });

            modelBuilder.Entity<Slvlbracket>(entity =>
            {
                entity.HasKey(e => new { e.Slvlcode, e.MonthsFrom })
                    .HasName("PK__SLVLBrac__C529EE7893A37494");

                entity.ToTable("SLVLBracket");

                entity.Property(e => e.Slvlcode)
                    .HasColumnName("SLVLCode")
                    .HasMaxLength(10);

                entity.Property(e => e.MonthsTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SickLeave).HasDefaultValueSql("((0))");

                entity.Property(e => e.VacationLeave).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Slvltable>(entity =>
            {
                entity.HasKey(e => e.Slvlcode)
                    .HasName("PK__SLVLTabl__5F40410ADD4CD9D4");

                entity.ToTable("SLVLTable");

                entity.Property(e => e.Slvlcode)
                    .HasColumnName("SLVLCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Slvldescription)
                    .HasColumnName("SLVLDescription")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Ssscertification>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNo, e.MonthCode })
                    .HasName("PK__SSSCerti__72FD6337696E0140");

                entity.ToTable("SSSCertification");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthCode)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AmountPaid)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertifiedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthDesc)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreparedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sbrno)
                    .HasColumnName("SBRNo")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TitleDesc)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.YearCode).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ssstable>(entity =>
            {
                entity.HasKey(e => e.BracketFrom)
                    .HasName("PK__SSSTable__5B355D261CA0E5B7");

                entity.ToTable("SSSTable");

                entity.Property(e => e.BracketFrom).HasColumnType("money");

                entity.Property(e => e.BracketTo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ecc)
                    .HasColumnName("ECC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Employee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Employer)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<SysVariables>(entity =>
            {
                entity.HasKey(e => e.VariableName)
                    .HasName("PK__SysVaria__6E717C3638F73F20");

                entity.Property(e => e.VariableName)
                    .HasMaxLength(130)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VariableValue)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TardinessTable>(entity =>
            {
                entity.HasKey(e => new { e.MinutesFrom, e.MinutesTo })
                    .HasName("PK__Tardines__A675AAE38A13E335");

                entity.Property(e => e.Deduction).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TaxStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode)
                    .HasName("PK__TaxStatu__6A7B44FDB314FBBA");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dependents)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalExempt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TaxStatusPrev>(entity =>
            {
                entity.HasKey(e => e.StatusCode)
                    .HasName("PK__TaxStatu__6A7B44FD0DE60B1B");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dependents)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DependentsProRated)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalExempt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonalExemptProRated)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TaxableLeaves>(entity =>
            {
                entity.HasKey(e => new { e.TransYear, e.EmployeeNo })
                    .HasName("PK__TaxableL__ACF3084AFA99AC56");

                entity.Property(e => e.TransYear).HasMaxLength(4);

                entity.Property(e => e.EmployeeNo).HasMaxLength(12);

                entity.Property(e => e.IncludeMonth)
                    .HasMaxLength(9)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludePagIbig)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludePhealth)
                    .HasColumnName("IncludePHealth")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IncludeSss)
                    .HasColumnName("IncludeSSS")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MonthCode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Slamount)
                    .HasColumnName("SLAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlamountNonTax)
                    .HasColumnName("SLAmountNonTax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Slhours)
                    .HasColumnName("SLHours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SlhoursNonTax)
                    .HasColumnName("SLHoursNonTax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxableAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vlamount)
                    .HasColumnName("VLAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VlamountTax)
                    .HasColumnName("VLAmountTax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vlhours)
                    .HasColumnName("VLHours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VlhoursTax)
                    .HasColumnName("VLHoursTax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wtax)
                    .HasColumnName("WTax")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UndertimeTable>(entity =>
            {
                entity.HasKey(e => new { e.MinutesFrom, e.MinutesTo })
                    .HasName("PK__Undertim__A675AAE3639B7E4A");

                entity.Property(e => e.Deduction).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.NameOfForm })
                    .HasName("PK__UserPerm__D564222608AB671E");

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NameOfForm)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrentRights)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserRights2>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.NameOfForm })
                    .HasName("PK__UserRigh__D56422265EAE882B");

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NameOfForm)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessRights)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelectForm)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Users__C9F28457514B59E4");

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FullName)
                    .HasMaxLength(35)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Locked)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserLevel)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserPword)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<VoucherAccount>(entity =>
            {
                entity.HasKey(e => new { e.VoucherCode, e.SeqNo, e.AccountCode })
                    .HasName("PK__VoucherA__D29DD325B802BA4B");

                entity.Property(e => e.VoucherCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.VoucherDetails)
                    .WithMany(p => p.VoucherAccount)
                    .HasForeignKey(d => new { d.VoucherCode, d.SeqNo })
                    .HasConstraintName("FK__VoucherAccount__51700577");
            });

            modelBuilder.Entity<VoucherDetails>(entity =>
            {
                entity.HasKey(e => new { e.VoucherCode, e.SeqNo })
                    .HasName("PK__VoucherD__B8A503E086E78BCF");

                entity.Property(e => e.VoucherCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AmountType)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DebitAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GlaccountCode)
                    .HasColumnName("GLAccountCode")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.VoucherCodeNavigation)
                    .WithMany(p => p.VoucherDetails)
                    .HasForeignKey(d => d.VoucherCode)
                    .HasConstraintName("FK__VoucherDe__Vouch__526429B0");
            });

            modelBuilder.Entity<VoucherHeader>(entity =>
            {
                entity.HasKey(e => e.VoucherCode)
                    .HasName("PK__VoucherH__7F0ABCA83D0891F3");

                entity.Property(e => e.VoucherCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });
        }
    }
}
