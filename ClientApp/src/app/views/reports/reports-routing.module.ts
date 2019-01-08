import { NgModule } from '@angular/core';
import {
  Routes,
  RouterModule
} from '@angular/router';

import { PeriodComponent } from './period/period.component';

const routes: Routes = [
  {
    path: '',
    component: PeriodComponent,
    data: {
      title: 'Reports'
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
export class ReportsRoutingModule { }
