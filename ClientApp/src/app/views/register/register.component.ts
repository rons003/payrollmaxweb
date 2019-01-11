import { Component } from '@angular/core';
import { Service, RegistrationViewModel } from '../../core/services/api.client.generated';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'register.component.html',
})
export class RegisterComponent {

  private registration: RegistrationViewModel;
  private ngDatePicker;
  private alertMessage = 'Invalid Information';
  constructor(private apiService: Service) {
    this.registration = new RegistrationViewModel();
  }

  register() {
    const year = this.ngDatePicker['year'].toString();
    const month = this.ngDatePicker['month'].toString();
    const day = this.ngDatePicker['day'].toString();
    this.registration.birthday = year + '-' + month + '-' + day;
    this.apiService.register(this.registration)
      .subscribe(
        response => {
          console.log(response);
        }
      );
  }

}
