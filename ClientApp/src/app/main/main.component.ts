import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../model/employee.model';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  private employees: Employee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Employee[]>(baseUrl + 'api/Employee').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}
