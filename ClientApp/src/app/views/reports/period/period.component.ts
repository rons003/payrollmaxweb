import { Component, OnInit } from '@angular/core';
import { Service, VwsEmployee, VwsPayrollHeader } from '../../../core/services/api.client.generated';

@Component({
  selector: 'app-period',
  templateUrl: './period.component.html',
  styleUrls: ['./period.component.scss']
})
export class PeriodComponent implements OnInit {

  private payrollPeriods: VwsPayrollHeader[];
  private employee: VwsEmployee;
  constructor(
    private apiService: Service
  ) {
    // this.employee = new VwsEmployee();
  }

  ngOnInit() {
  }

  searchEmployee(empno: string) {
    this.getEmployee(empno);
    this.getPayrollHeader(empno);
  }

  getPayrollHeader(empno: string) {
    this.apiService.getPayrollPeriod(Number(empno))
      .subscribe(
        response => {
          this.payrollPeriods = response;
        }
      );
  }

  viewReport(empno: string, period: string) {
    window.open('http://localhost:59652/Report/ExportReport?' + 'empno=' + empno + '&payrollperiod=' + period, '_blank');
  }

  getEmployee(empno: string) {
    this.apiService.getVwsEmployee(empno)
      .subscribe(
        (res: any) => {
          if (res != null) {
            this.employee = res;
          }
        }
      );
  }

}
