import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FloodScreenComponent } from './flood-screen.component';

describe('FloodScreenComponent', () => {
  let component: FloodScreenComponent;
  let fixture: ComponentFixture<FloodScreenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FloodScreenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FloodScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
