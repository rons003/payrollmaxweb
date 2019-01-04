import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { Service } from './core/services/api.client.generated';

@Injectable()
export class AuthGuard implements CanActivate {
    constructor(private apiService: Service, private router: Router) { }

    canActivate() {

        if (!this.apiService.isLoggedIn()) {
            this.router.navigate(['/login']);
            return false;
        }

        return true;
    }
}
