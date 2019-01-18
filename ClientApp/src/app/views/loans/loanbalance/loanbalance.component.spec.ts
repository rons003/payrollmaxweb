import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoanbalanceComponent } from './loanbalance.component';

describe('LoanbalanceComponent', () => {
  let component: LoanbalanceComponent;
  let fixture: ComponentFixture<LoanbalanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoanbalanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoanbalanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
