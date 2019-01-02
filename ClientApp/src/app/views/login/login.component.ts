import { Component } from '@angular/core';
import { Service, Employee, CredentialsViewModel } from '../../core/services/api.client.generated';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent {

  // Observable navItem source
  private _authNavStatusSource = new BehaviorSubject<boolean>(false);
  // Observable navItem stream
  authNavStatus$ = this._authNavStatusSource.asObservable();
  private loggedIn = false;

  constructor(
    private apiService: Service
  ) {
    this.loggedIn = !!localStorage.getItem('auth_token');

  }

  login(username: string, password: string) {
    const credentials = new CredentialsViewModel();
    credentials.userName = username;
    credentials.password = password;
    this.apiService.login(credentials)
      .subscribe(response => {
        // localStorage.setItem('auth_token', response['auth_token']);
        // this.loggedIn = true;
        console.log(response);
      });
  }

  logout() {
    localStorage.removeItem('auth_token');
    this.loggedIn = false;
    this._authNavStatusSource.next(false);
  }

  isLoggedIn() {
    return this.loggedIn;
  }
}
