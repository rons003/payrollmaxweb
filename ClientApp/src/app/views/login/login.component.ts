import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Service, CredentialsViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';
import Swal from 'sweetalert2';
import {
  FormGroup,
  FormBuilder,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent implements OnInit {

  credentials: CredentialsViewModel;
  alertValidation = false;
  alertMessage = '';
  primaryModal;
  formForgot: FormGroup;
  constructor(
    private apiService: Service,
    private router: Router, private authService: AuthService,
    private formBuilder: FormBuilder,
  ) {
    this.credentials = new CredentialsViewModel();
  }

  ngOnInit() {
    this.formForgot = this.formBuilder.group({
      employeeNo: [null, [Validators.required, Validators.pattern('[0-9 ]*')]],
      lastname: [null, [Validators.required]],
      birthday: [null, Validators.required],
      questionOne: [null, Validators.required],
      questionTwo: [null, Validators.required],
      questionThree: [null, Validators.required]
    }
    );
    if (this.authService.isAuthenticated()) {
      this.router.navigate(['']);
    }
  }

  login() {
    this.apiService.login(this.credentials)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.alertValidation = false;
            this.authService.saveCurrentUser(
              response.responseData['id'],
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

  forgotPass() {

  }
}
