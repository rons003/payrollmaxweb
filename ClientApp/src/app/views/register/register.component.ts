import { Component, OnInit } from '@angular/core';
import { Service, RegistrationViewModel, CredentialsViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormControl
} from '@angular/forms';
import { ConfirmPasswordValidator } from './confirm-password.validator';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'register.component.html',
})
export class RegisterComponent implements OnInit {

  formreg: FormGroup;
  alertValidation = false;
  alertMessage = '';
  constructor(
    private apiService: Service,
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {
  }

  ngOnInit() {
    this.formreg = this.formBuilder.group({
      username: [null, [Validators.required, Validators.pattern('[0-9 ]*')]],
      middleinitial: [null, [Validators.required, Validators.maxLength(1), Validators.pattern('[a-zA-Z ]*')]],
      birthday: [null, Validators.required],
      email: [null, [Validators.required, Validators.email]],
      password: [null, Validators.required],
      confirmpassword: [null, Validators.required],
    }, {
        validator: ConfirmPasswordValidator.MatchPassword
      }
    );
  }

  register() {
    const birthdaydp = this.formreg.controls.birthday.value;
    const year = birthdaydp['year'].toString();
    const month = birthdaydp['month'].toString();
    const day = birthdaydp['day'].toString();
    const birthday = year + '-' + month + '-' + day;
    const registration = new RegistrationViewModel();
    registration.userName = this.formreg.controls.username.value;
    registration.middleInitial = this.formreg.controls.middleinitial.value;
    registration.birthday = birthday;
    registration.email = this.formreg.controls.email.value;
    registration.password = this.formreg.controls.password.value;
    this.apiService.register(registration)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.alertValidation = false;
            this.login(registration.userName, registration.password);
          } else {
            this.alertMessage = response.message;
            this.alertValidation = true;
          }
        }
      );
  }

  login(username: string, password: string) {
    const credentials = new CredentialsViewModel();
    credentials.userName = username;
    credentials.password = password;
    this.apiService.login(credentials)
      .subscribe(
        response => {
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
        }
      );
  }

}
