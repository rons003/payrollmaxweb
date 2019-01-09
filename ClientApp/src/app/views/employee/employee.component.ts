import { Component, OnInit } from '@angular/core';
import { Service } from '../../core/services/api.client.generated';

@Component({
  templateUrl: './employee.component.html'
  // styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  public primaryModal;


  constructor(private apiService: Service) {
    // this.getEmployeeAll();
  }

  getEmployeeAll() {
    //
  }

  ngOnInit() {
  }

}
