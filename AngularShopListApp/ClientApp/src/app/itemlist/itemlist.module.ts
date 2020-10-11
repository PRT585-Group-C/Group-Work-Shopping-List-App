import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ItemlistRoutingModule } from './itemlist-routing.module';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AutocompleteLibModule } from 'angular-ng-autocomplete';

@NgModule({
  declarations: [IndexComponent, ViewComponent, CreateComponent],
  imports: [
    CommonModule,
    ItemlistRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    AutocompleteLibModule
  ]
})
export class ItemlistModule { }
