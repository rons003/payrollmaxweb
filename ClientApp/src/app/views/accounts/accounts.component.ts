import { Component, OnInit } from '@angular/core';
import { Service, AppUser } from '../../core/services/api.client.generated';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.scss']
})
export class AccountsComponent implements OnInit {
  accounts: AppUser[];
  constructor(
    public apiService: Service
  ) { }

  ngOnInit() {
    this.getAllAccounts();
  }

  getAllAccounts() {
    this.apiService.getAllUsers()
      .subscribe(
        response => {
          this.accounts = response;
        }
      );
  }

  searchAccount(empno: string) {
    if (empno === '') {
      this.getAllAccounts();
    } else {
      this.apiService.searchUser(empno)
        .subscribe(
          response => {
            this.accounts = response;
          }
        );
    }
  }

  deleteAccount(userid: string) {
    this.apiService.deleteAccount(userid)
      .subscribe(
        response => {
          if (response.result === 'success') {
            this.getAllAccounts();
          }
        }
      );
  }

}
