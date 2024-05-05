import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiseasesComponent } from './diseases.component';

describe('DiseasesComponent', () => {
  let component: DiseasesComponent;
  let fixture: ComponentFixture<DiseasesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DiseasesComponent]
    });
    fixture = TestBed.createComponent(DiseasesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
