import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Service, CredentialsViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent {

  private credentials: CredentialsViewModel;

  constructor(
    private apiService: Service,
    private router: Router, private authService: AuthService
  ) {
    this.credentials = new CredentialsViewModel();
  }

  login() {
    this.apiService.login(this.credentials)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.authService.saveCurrentUser(
              response.responseData['auth_token'],
              response.responseData['role'],
              response.responseData['employee_info']
            );
            this.router.navigate(['/reports']);
            // console.log(this.authService.getCurrentUser());
          } else {
            console.log(response.message);
          }
        }
      );
  }
}
