import { Component, OnInit } from '@angular/core';
import { Service, Employee } from '../../core/services/api.client.generated';

@Component({
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  private employees: Employee[];

  constructor(private apiService: Service) {
    this.getEmployeeAll();
  }

  getEmployeeAll() {
    this.apiService.getEmployeeAll()
      .subscribe(response => {
        this.employees = response;
      });
  }

  ngOnInit() {
  }

}
