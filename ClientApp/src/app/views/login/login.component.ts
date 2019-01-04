import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Service, CredentialsViewModel } from '../../core/services/api.client.generated';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})

export class LoginComponent implements OnInit, OnDestroy {

  private subscription: Subscription;

  errors: string;
  isRequesting: boolean;
  submitted = false;
  credentials = new CredentialsViewModel({ userName: '', password: '' });

  constructor(
    private apiService: Service,
    private router: Router, private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    // subscribe to router event
    this.subscription = this.activatedRoute.queryParams.subscribe(
      (param: any) => {
        this.credentials.userName = param['userName'];
      });
  }

  ngOnDestroy() {
    // prevent memory leak by unsubscribing
    this.subscription.unsubscribe();
  }

  login({ value, valid }: { value: CredentialsViewModel, valid: boolean }) {
    this.submitted = true;
    this.isRequesting = true;
    this.errors = '';
    if (valid) {
      this.apiService.login(value)
        // .finally(() => this.isRequesting = false)
        .subscribe(
          response => {
            console.log(response);
            if (response) {
              this.router.navigate(['/dashboard']);
            }
          },
          error => this.errors = error);
    }
  }

}
