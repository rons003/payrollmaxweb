import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { ProfileComponent } from './profile.component';
import { ProfileRoutingModule } from './profile-routing.module';
import { TabsModule } from 'ngx-bootstrap/tabs';

@NgModule({
    imports: [
        CommonModule, FormsModule,
        ReactiveFormsModule,
        ProfileRoutingModule,
        TabsModule
    ],
    declarations: [ProfileComponent]
})
export class ProfileModule { }
