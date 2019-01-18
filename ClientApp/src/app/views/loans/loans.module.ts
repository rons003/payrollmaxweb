import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { LoanbalanceComponent } from './loanbalance/loanbalance.component';
import { LoansRoutingModule } from './loans-routing.module';

@NgModule({
    imports: [
        CommonModule, FormsModule,
        LoansRoutingModule
    ],
    declarations: [LoanbalanceComponent]
})
export class LoansModule { }
