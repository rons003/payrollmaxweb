import { NgModule } from '@angular/core';
import {
    Routes,
    RouterModule
} from '@angular/router';

import { AccountsComponent } from './accounts.component';

const routes: Routes = [
    {
        path: '',
        component: AccountsComponent,
        data: {
            title: 'Accounts'
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
export class AccountsRoutingModule { }
