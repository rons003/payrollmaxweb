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
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

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
  // Secret Question
  secretQuestion = '';
  closeResult: string;
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

  open(content) {
    const secretQuestions = ['questionOne', 'questionTwo', 'questionThree'];
    const pickQuestion = secretQuestions[Math.floor(Math.random() * secretQuestions.length)];
    if (pickQuestion === 'questionOne') {
      this.secretQuestion = 'What was your childhood nickname?';
    } else if (pickQuestion === 'questionTwo') {
      this.secretQuestion = 'What is your pets name?';
    } else if (pickQuestion === 'questionThree') {
      this.secretQuestion = 'In what year was your mother born?';
    }
    console.log(pickQuestion);
    this.modalService.open(content, { size: 'sm' });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
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
