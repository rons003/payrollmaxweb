import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';
import { Service, VwsEmployee } from '../../core/services/api.client.generated';

@Injectable()
export class AuthService {
    constructor() {
    }

    logout() {
        // this.user = null;
        this.clearCurrentUser();
    }

    // updateActiveUser(user: User) {
    //     const token = this.getCurrentUser().token;
    //     this.saveCurrentUser(token, user);
    // }

    // changePassword(oldPassword: string, newPassword: string): Observable<boolean> {
    //     const user = this.getActiveUser();
    //     return this.userService.changePassword(user.id, oldPassword, newPassword);
    // }

    saveCurrentUser(token: any, role: any, user: VwsEmployee) {
        localStorage.setItem('currentUser', JSON.stringify({ token: token, role: role, user: user }));
    }

    getCurrentUser() {
        return JSON.parse(localStorage.getItem('currentUser'));
    }

    clearCurrentUser() {
        localStorage.setItem('currentUser', null);
    }

    isLoggedIn(): boolean {
        const data = this.getCurrentUser();
        return data && data.token;
    }


    isActiveUserSuperAdmin(): boolean {
        if (this.getCurrentUser()) {
            const role = this.getCurrentUser().role;
            return role && role === 'Admin' ;
        } else {
            return false;
        }
    }

    isActiveUserEmployee(): boolean {
        if (this.getCurrentUser()) {
            const role = this.getCurrentUser().role;
            return role && role === 'Employee' ;
        } else {
            return false;
        }
    }

    getActiveUserName(): string {
        const user = this.getCurrentUser().user;
        return user.firstName + ' ' + user.lastName;
    }

    // getActiveUser(): User {
    //     return User.parse(this.getCurrentUser().user);
    // }
}
