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

}
