import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SteluteComponent } from './stelute.component';

describe('SteluteComponent', () => {
  let component: SteluteComponent;
  let fixture: ComponentFixture<SteluteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SteluteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SteluteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
