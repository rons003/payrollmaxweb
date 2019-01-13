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
    private authService: AuthService,
    private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    const authdata = this.authService.getCurrentUser();

    this.formProfile = this.formBuilder.group({
      userType: authdata.role[0],
      empNo: authdata.user.employeeNo,
      empName: authdata.user.employeeName,
      birthday: authdata.user.birthday
    });
  }

}
