import { Component, OnDestroy } from '@angular/core';
import { navItems } from './../../_nav';
import { navItemsEmp } from './../../_navemployee';
import { Service } from '../../core/services/api.client.generated';
import { Router } from '@angular/router';
import { AuthService } from '../../shared/authentication/auth.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './default-layout.component.html'
})
export class DefaultLayoutComponent implements OnDestroy {
  public navItems;
  public sidebarMinimized = true;
  private changes: MutationObserver;
  public element: HTMLElement = document.body;
  constructor(private apiService: Service, private router: Router, private authService: AuthService) {
    if (this.authService.isActiveUserSuperAdmin()) {
      this.navItems = navItems;
    } else {
      this.navItems = navItemsEmp;
    }
    this.changes = new MutationObserver((mutations) => {
      this.sidebarMinimized = document.body.classList.contains('sidebar-minimized');
    });

    this.changes.observe(<Element>this.element, {
      attributes: true,
      attributeFilter: ['class']
    });
  }

  ngOnDestroy(): void {
    this.changes.disconnect();
  }

  logout() {
    this.authService.logout();
    this.router.navigate(['/login']);
  }
}
