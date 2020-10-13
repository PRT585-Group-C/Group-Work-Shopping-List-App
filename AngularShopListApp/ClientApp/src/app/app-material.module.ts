import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule, MatCardModule, MatCheckboxModule, MatFormFieldModule, MatGridListModule, MatIconModule, MatInputModule, MatToolbarModule } from '@angular/material';



@NgModule({
  
  declarations: [],
  imports: [
    CommonModule,
    MatCheckboxModule,
    MatButtonModule,
    MatCardModule,
    MatButtonModule,
    MatIconModule,
    MatInputModule,
    MatGridListModule,
    MatFormFieldModule,
    MatInputModule,
    MatToolbarModule
  ],

  exports: [
    MatCheckboxModule,
    MatButtonModule,
    MatCardModule,
    MatButtonModule,
    MatIconModule,
    MatInputModule,
    MatGridListModule,
    MatFormFieldModule,
    MatInputModule,
    MatToolbarModule
    

  ]
})
export class AppMaterialModule { }
