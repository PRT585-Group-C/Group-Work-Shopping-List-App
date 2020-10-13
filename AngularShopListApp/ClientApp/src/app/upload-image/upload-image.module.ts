import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UploadImageComponent } from './upload-image.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [UploadImageComponent],
  imports: [
    CommonModule
  ],
  exports: [UploadImageComponent]
})
export class UploadImageModule { }
