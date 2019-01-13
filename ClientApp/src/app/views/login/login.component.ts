import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Service, CredentialsViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent {

  private credentials: CredentialsViewModel;
  alertValidation = false;
  alertMessage = '';
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
            this.alertValidation = false;
            this.authService.saveCurrentUser(
              response.responseData['auth_token'],
              response.responseData['role'],
              response.responseData['employee_info']
            );
            this.router.navigate(['/reports']);
            const toast = Swal.mixin({
              toast: true,
              position: 'top-end',
              showConfirmButton: false,
              timer: 3000
            });

            toast({
              type: 'success',
              title: 'Signed in successfully'
            });
          } else {
            this.alertMessage = response.message;
            this.alertValidation = true;
          }
        }
      );
  }
}
