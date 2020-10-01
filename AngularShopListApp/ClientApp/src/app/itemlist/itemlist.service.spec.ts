import { TestBed } from '@angular/core/testing';

import { ItemlistService } from './itemlist.service';

describe('ItemlistService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ItemlistService = TestBed.get(ItemlistService);
    expect(service).toBeTruthy();
  });
});
