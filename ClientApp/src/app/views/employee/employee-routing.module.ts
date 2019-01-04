import { NgModule } from '@angular/core';
import {
  Routes,
  RouterModule
} from '@angular/router';

import { EmployeeComponent } from './employee.component';

const routes: Routes = [
  {
    path: '',
    component: EmployeeComponent,
    data: {
      title: 'Employee Management'
    }
    // children: [
    //   {
    //     path: '',
    //     redirectTo: 'setup'
    //   },
    //   {
    //     path: 'setup',
    //     component: EmployeeComponent,
    //     data: {
    //       title: 'Setup'
    //     }
    //   }
    // ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmployeeRoutingModule { }
