import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../shared/authentication/auth.service';
import {
  FormGroup,
  FormBuilder
} from '@angular/forms';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss'],
  providers: [DatePipe]
})
export class ProfileComponent implements OnInit {
  formProfile: FormGroup;
  constructor(
    public authService: AuthService,
    public formBuilder: FormBuilder,
    private datePipe: DatePipe
  ) { }

  ngOnInit() {
    const authdata = this.authService.getCurrentUser();

    this.formProfile = this.formBuilder.group({
      userType: [{ value: authdata.role[0], disabled: true }],
      empNo: [{ value: authdata.user.employeeNo, disabled: true }],
      empName: [{ value: authdata.user.employeeName, disabled: true }],
      address1: [{ value: authdata.user.address01, disabled: true }],
      address2: [{ value: '', disabled: true }],
      telephone1: [{ value: authdata.user.telephone01, disabled: true }],
      birthday: [{ value: this.datePipe.transform(new Date(authdata.user.birthday), 'yyyy-MM-dd'), disabled: true }],
      dateHired: [{ value: this.datePipe.transform(new Date(authdata.user.dateHired), 'yyyy-MM-dd'), disabled: true }],
      position: [{ value: authdata.user.empPosition, disabled: true }],
      sssNo: [{ value: authdata.user.sssNo, disabled: true }],
      philHealthNo: [{ value: authdata.user.philHealthNo, disabled: true }],
      pagIbigNo: [{ value: authdata.user.pagIbigNo, disabled: true }],
      taxIdNo: [{ value: authdata.user.taxIDNo, disabled: true }],
      taxStatus: [{ value: authdata.user.taxStatus, disabled: true }]
    });
  }

}
