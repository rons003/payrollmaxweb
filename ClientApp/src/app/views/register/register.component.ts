import { Component, OnInit } from '@angular/core';
import { Service, RegistrationViewModel } from '../../core/services/api.client.generated';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormControl
} from '@angular/forms';
import { ConfirmPasswordValidator } from './confirm-password.validator';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'register.component.html',
})
export class RegisterComponent implements OnInit {

  formreg: FormGroup;
  alertValidation = false;
  alertMessage = '';
  constructor(private apiService: Service, private formBuilder: FormBuilder) {
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
          } else {
            console.log(response.message);
            this.alertMessage = response.message;
            this.alertValidation = true;
          }
        }
      );
  }

}
