import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';

import { AuthService } from './auth.service';

@Injectable()
export class EmployeeGuard implements CanActivate {

    constructor(private auth: AuthService, private router: Router) { }

    canActivate() {
        // If the user is not an employee, we'll send them back to the home page
        if (!this.auth.isActiveUserEmployee()) {
            this.router.navigate(['login']);
            return false;
        }
        return true;
    }
}
