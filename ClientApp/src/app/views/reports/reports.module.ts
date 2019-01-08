import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { PeriodComponent } from './period/period.component';
import { ReportsRoutingModule } from './reports-routing.module';

@NgModule({
    imports: [
        CommonModule, FormsModule,
        ReportsRoutingModule
    ],
    declarations: [PeriodComponent]
})
export class ReportsModule { }
