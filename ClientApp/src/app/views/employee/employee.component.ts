import { Component, OnInit } from '@angular/core';
import { Service, Employee, PayrollHeader } from '../../core/services/api.client.generated';

@Component({
  templateUrl: './employee.component.html'
  // styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  public primaryModal;
  private employees: Employee[];
  private payrollPeriods: PayrollHeader[];

  constructor(private apiService: Service) {
    // this.getEmployeeAll();
  }

  getEmployeeAll() {
    this.apiService.getEmployeeAll()
      .subscribe(response => {
        this.employees = response;
      });
  }

  getPayrollHeader(empno: string) {
    console.log(empno);
    this.apiService.getPayrollHeader(empno)
      .subscribe(response => {
        this.payrollPeriods = response;
      });
  }

  ngOnInit() {
  }

}
