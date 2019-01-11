import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';
import { Service } from '../../core/services/api.client.generated';

@Injectable()
export class AuthService {
    constructor() {
    }

    // logout() {
    //     this.user = null;
    //     this.clearCurrentUser();
    // }

    // updateActiveUser(user: User) {
    //     const token = this.getCurrentUser().token;
    //     this.saveCurrentUser(token, user);
    // }

    // changePassword(oldPassword: string, newPassword: string): Observable<boolean> {
    //     const user = this.getActiveUser();
    //     return this.userService.changePassword(user.id, oldPassword, newPassword);
    // }

    // saveCurrentUser(token: any, user: User) {
    //     localStorage.setItem('currentUser', JSON.stringify({ token: token, user: user }));
    // }

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

    isActiveUserStudent(): boolean {
        if (this.getCurrentUser()) {
            const user = this.getCurrentUser().user;
            return user && user.userType === 0;
        } else {
            return false;
        }
    }

    isActiveUserTeacher(): boolean {
        if (this.getCurrentUser()) {
            const user = this.getCurrentUser().user;
            return user && user.userType === 1;
        } else {
            return false;
        }
    }

    isActiveUserAdmin(): boolean {
        if (this.getCurrentUser()) {
            const user = this.getCurrentUser().user;
            return user && user.userType === 2;
        } else {
            return false;
        }
    }

    isActiveUserSuperAdmin(): boolean {
        if (this.getCurrentUser()) {
            const user = this.getCurrentUser().user;
            return user && user.userType === 3;
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
