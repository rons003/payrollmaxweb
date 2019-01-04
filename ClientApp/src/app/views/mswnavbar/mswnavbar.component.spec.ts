import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MswnavbarComponent } from './mswnavbar.component';

describe('MswnavbarComponent', () => {
  let component: MswnavbarComponent;
  let fixture: ComponentFixture<MswnavbarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MswnavbarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MswnavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
