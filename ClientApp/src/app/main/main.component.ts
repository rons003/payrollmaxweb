import { Component, OnInit, Inject } from '@angular/core';
import { Service, Employee } from '../core/services/api.client.generated';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  private employees: Employee[];

  constructor(private apiService: Service) {
    apiService.getEmployeeAll().subscribe(response => {
      this.employees = response;
    });
  }

  ngOnInit() {
  }

}
