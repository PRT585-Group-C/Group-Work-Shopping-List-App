import { TestBed } from '@angular/core/testing';

import { NewitemService } from './newitem.service';

describe('NewitemService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NewitemService = TestBed.get(NewitemService);
    expect(service).toBeTruthy();
  });
});
