import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { AccountsComponent } from './accounts.component';
import { AccountsRoutingModule } from './accounts-routing.module';

@NgModule({
    imports: [
        CommonModule, FormsModule,
        AccountsRoutingModule
    ],
    declarations: [AccountsComponent]
})
export class AccountsModule { }
