import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../shared/authentication/auth.service';
import {
  FormGroup,
  FormBuilder
} from '@angular/forms';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  formProfile: FormGroup;
  constructor(
    public authService: AuthService,
    public formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    const authdata = this.authService.getCurrentUser();

    this.formProfile = this.formBuilder.group({
      userType: [{ value: authdata.role[0], disabled: true }],
      empNo: [{ value: authdata.user.employeeNo, disabled: true }],
      empName: [{ value: authdata.user.employeeName, disabled: true }],
      birthday: [{ value: authdata.user.birthday, disabled: true }]
    });
  }

}
