import { Component, OnInit } from '@angular/core';
import { Service, VwsEmployee, VwsPayrollHeader } from '../../../core/services/api.client.generated';
import Swal from 'sweetalert2';
import { AuthService } from '../../../shared/authentication/auth.service';
import * as CryptoJS from 'crypto-js';

@Component({
  selector: 'app-period',
  templateUrl: './period.component.html',
  styleUrls: ['./period.component.scss']
})
export class PeriodComponent implements OnInit {

  payrollPeriods: VwsPayrollHeader[];
  employee: VwsEmployee;

  constructor(
    public apiService: Service,
    public authService: AuthService
  ) {
    this.employee = new VwsEmployee();
  }

  ngOnInit() {
    if (this.authService.isActiveUserEmployee()) {
      const empno = this.authService.getCurrentUser().user.employeeNo;
      this.getPayrollHeader(empno);
    }
  }

  setEncryptedData(details: string) {
    const key = CryptoJS.enc.Utf8.parse('iloveyouaivy0714');
    const iv = CryptoJS.enc.Utf8.parse('iloveyouaivy0714');
    const keySettings = {
      keySize: 128 / 8,
      iv: iv,
      mode: CryptoJS.mode.CBC,
      padding: CryptoJS.pad.Pkcs7
    };
    const encryptedString = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(details), key, keySettings);
    return encryptedString;
  }

  searchEmployee(empno: string) {
    this.getEmployee(empno);
    this.getPayrollHeader(empno);
  }

  getPayrollHeader(empno: string) {
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
    const eEmpNo = this.setEncryptedData(empno);
    const ePeriod = this.setEncryptedData(period);
    window.open('http://localhost:59652/Payslip/Report?' + 'empno=' + eEmpNo + '&payrollperiod=' + ePeriod, '_blank');
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
