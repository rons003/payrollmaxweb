import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Service, CredentialsViewModel, ForgotPassViewModel } from '../../core/services/api.client.generated';
import { AuthService } from '../../shared/authentication/auth.service';
import Swal from 'sweetalert2';
import {
  FormGroup,
  FormBuilder,
  Validators
} from '@angular/forms';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent implements OnInit {

  credentials: CredentialsViewModel;
  alertValidationFailed = false;
  alertValidationFailedForgot = false;
  alertMessage = '';
  alertValidationSuccess = false;
  formForgot: FormGroup;
  // Secret Question
  secretQuestion = '';
  closeResult: string;
  pickQuestion: number;
  constructor(
    private apiService: Service,
    private router: Router, private authService: AuthService,
    private formBuilder: FormBuilder,
    private modalService: NgbModal
  ) {
    this.credentials = new CredentialsViewModel();
  }

  ngOnInit() {
    this.formForgot = this.formBuilder.group({
      employeeNo: [null, [Validators.required, Validators.pattern('[0-9 ]*')]],
      lastname: [null, [Validators.required]],
      birthday: [null, Validators.required],
      secretQuestion: [null, Validators.required]
    }
    );
    if (this.authService.isAuthenticated()) {
      this.router.navigate(['']);
    }
  }

  open(content: any) {
    this.modalService.open(content, { size: 'sm', backdrop: 'static' });
    this.randomPicker();
  }

  closeModal() {
    this.modalService.dismissAll();
    console.log('close modal');
  }

  randomPicker() {
    const secretQuestions = [1, 2, 3];
    this.pickQuestion = secretQuestions[Math.floor(Math.random() * secretQuestions.length)];
    console.log(this.pickQuestion);
    switch (this.pickQuestion) {
      case 1:
        this.secretQuestion = 'What was your childhood nickname?';
        break;
      case 2:
        this.secretQuestion = 'What is your pets name?';
        break;
      case 3:
        this.secretQuestion = 'In what year was your mother born?';
        break;
    }
  }

  login() {
    this.apiService.login(this.credentials)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.alertValidationFailed = false;
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
            this.alertValidationFailed = true;
          }
        }
      );
  }

  forgotPass() {
    const birthdaydp = this.formForgot.controls.birthday.value;
    const year = birthdaydp['year'].toString();
    const month = birthdaydp['month'].toString();
    const day = birthdaydp['day'].toString();
    const birthday = year + '-' + month + '-' + day;
    const forgotPassModel = new ForgotPassViewModel();
    forgotPassModel.userName = this.formForgot.controls.employeeNo.value;
    forgotPassModel.lastName = this.formForgot.controls.lastname.value;
    forgotPassModel.birthday = birthday;
    forgotPassModel.secretQuestion = this.pickQuestion;
    forgotPassModel.secretAnswer = this.formForgot.controls.secretQuestion.value;

    this.apiService.forgotPassword(forgotPassModel)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.alertMessage = response.message;
            this.alertValidationSuccess = true;
            this.alertValidationFailedForgot = false;
            this.formForgot.reset();
          } else {
            this.alertMessage = response.message;
            this.alertValidationSuccess = false;
            this.alertValidationFailedForgot = true;
            this.randomPicker();
            this.formForgot.reset();
          }
        }
      );
  }
}
