import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmployeeComponent } from './employee.component';
import { EmployeeRoutingModule } from './employee-routing.module';

// Modal Component
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
  imports: [
    CommonModule,
    EmployeeRoutingModule,
    ModalModule.forRoot()
  ],
  declarations: [ EmployeeComponent ]
})
export class EmployeeModule { }
