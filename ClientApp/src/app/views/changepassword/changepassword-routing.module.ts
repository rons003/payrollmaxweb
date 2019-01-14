import { NgModule } from '@angular/core';
import {
    Routes,
    RouterModule
} from '@angular/router';

import { ChangepasswordComponent } from './changepassword.component';

const routes: Routes = [
    {
        path: '',
        component: ChangepasswordComponent,
        data: {
            title: 'Change Password'
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
export class ChangepasswordRoutingModule { }
