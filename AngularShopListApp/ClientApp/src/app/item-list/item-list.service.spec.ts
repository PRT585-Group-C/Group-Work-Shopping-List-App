import { TestBed } from '@angular/core/testing';

import { ItemListService } from './item-list.service';

describe('ItemListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ItemListService = TestBed.get(ItemListService);
    expect(service).toBeTruthy();
  });
});
