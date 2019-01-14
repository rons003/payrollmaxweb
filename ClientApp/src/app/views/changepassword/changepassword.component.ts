import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators
} from '@angular/forms';
import { ConfirmPasswordValidator } from '../register/confirm-password.validator';
import Swal from 'sweetalert2';
import { Service, ChangepassViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';

@Component({
  selector: 'app-changepassword',
  templateUrl: './changepassword.component.html',
  styleUrls: ['./changepassword.component.scss']
})
export class ChangepasswordComponent implements OnInit {
  formChangePass: FormGroup;
  alertValidationFailed = false;
  alertMessage = '';
  alertValidationSuccess = false;
  constructor(
    private formBuilder: FormBuilder,
    private apiService: Service,
    private authService: AuthService
  ) { }

  ngOnInit() {
    this.formChangePass = this.formBuilder.group({
      currentPassword: [null, Validators.required],
      password: [null, [Validators.required, Validators.minLength(6)]],
      confirmpassword: [null, [Validators.required, Validators.minLength(6)]],
    }, {
        validator: ConfirmPasswordValidator.MatchPassword
      }
    );
  }

  changePassword() {
    const userid = this.authService.getCurrentUser().userid;
    const changePassViewModel = new ChangepassViewModel();
    changePassViewModel.id = userid;
    changePassViewModel.oldPassword = this.formChangePass.controls.currentPassword.value;
    changePassViewModel.newPassword = this.formChangePass.controls.password.value;
    this.apiService.changePassword(changePassViewModel)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.alertValidationFailed = false;
            this.alertMessage = response.message;
            this.alertValidationSuccess = true;
            this.formChangePass.reset();
          } else {
            this.alertMessage = response.message;
            this.alertValidationFailed = true;
          }
        }
      );
  }

}
