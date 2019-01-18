import { NgModule } from '@angular/core';
import {
    Routes,
    RouterModule
} from '@angular/router';

import { LoanbalanceComponent } from './loanbalance/loanbalance.component';

const routes: Routes = [
    {
        path: '',
        component: LoanbalanceComponent,
        data: {
            title: 'Loan'
        }
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LoansRoutingModule { }
