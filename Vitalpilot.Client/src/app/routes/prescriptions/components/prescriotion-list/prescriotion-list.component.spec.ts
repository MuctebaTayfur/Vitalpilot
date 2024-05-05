import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrescriotionListComponent } from './prescriotion-list.component';

describe('PrescriotionListComponent', () => {
  let component: PrescriotionListComponent;
  let fixture: ComponentFixture<PrescriotionListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PrescriotionListComponent]
    });
    fixture = TestBed.createComponent(PrescriotionListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
