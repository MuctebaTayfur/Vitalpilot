import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaseContentWithSidenavComponent } from './base-content-with-sidenav.component';

describe('BaseContentWithSidenavComponent', () => {
  let component: BaseContentWithSidenavComponent;
  let fixture: ComponentFixture<BaseContentWithSidenavComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BaseContentWithSidenavComponent]
    });
    fixture = TestBed.createComponent(BaseContentWithSidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
