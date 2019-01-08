import { Component, OnInit } from '@angular/core';
import { Service, PayrollHeader, Employees, Employee } from '../../../core/services/api.client.generated';

@Component({
  selector: 'app-period',
  templateUrl: './period.component.html',
  styleUrls: ['./period.component.scss']
})
export class PeriodComponent implements OnInit {

  private payrollPeriods: PayrollHeader[];
  private employee: Employees;
  constructor(
    private apiService: Service
  ) {
    this.employee = new Employee();
  }

  ngOnInit() {
  }

  searchEmployee(empno: string) {
    this.getEmployee(empno);
    this.getPayrollHeader(empno);
  }

  getPayrollHeader(empno: string) {
    this.apiService.getPayrollHeader(empno)
      .subscribe(response => {
        this.payrollPeriods = response;
      });
  }

  viewReport(empno: string, period: string) {
    window.open('http://localhost:59652/Report/ExportReport?' + 'empno=' + empno + '&payrollperiod=' + period, '_blank');
  }

  getEmployee(empno: string) {
    this.apiService.getEmployees(empno)
      .subscribe(
        (res: any) => {
          if (res != null) {
            this.employee = res;
          }
        }
      );
  }

}
