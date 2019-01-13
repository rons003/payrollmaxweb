import { Component, OnInit } from '@angular/core';
import { Service, VwsEmployee, VwsPayrollHeader } from '../../../core/services/api.client.generated';
import Swal from 'sweetalert2';
import { AuthService } from '../../../shared/authentication/auth.service';

@Component({
  selector: 'app-period',
  templateUrl: './period.component.html',
  styleUrls: ['./period.component.scss']
})
export class PeriodComponent implements OnInit {

  private payrollPeriods: VwsPayrollHeader[];
  private employee: VwsEmployee;
  constructor(
    private apiService: Service,
    private authService: AuthService
  ) {
    this.employee = new VwsEmployee();
  }

  ngOnInit() {
    if (this.authService.isActiveUserEmployee()) {
      const empno = this.authService.getCurrentUser().user.employeeNo;
      this.getPayrollHeader(empno);
    }
  }

  searchEmployee(empno: string) {
    this.getEmployee(empno);
    this.getPayrollHeader(empno);
  }

  getPayrollHeader(empno: string) {
    // Swal({
    //   title: 'Fetching Data...'
    // });
    Swal.showLoading();
    this.apiService.getPayrollPeriod(Number(empno))
      .subscribe(
        response => {
          this.payrollPeriods = response;
          Swal.close();
        }
      );
  }

  viewReport(empno: string, period: string) {
    window.open('http://localhost:59652/Report/ExportReport?' + 'empno=' + empno + '&payrollperiod=' + period, '_blank');
  }

  getEmployee(empno: string) {
    this.employee = new VwsEmployee();
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
