import { TestBed } from '@angular/core/testing';

import { UploadFilesService } from './upload-image.service';

describe('UploadImageService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UploadFilesService = TestBed.get(UploadFilesService);
    expect(service).toBeTruthy();
  });
});
