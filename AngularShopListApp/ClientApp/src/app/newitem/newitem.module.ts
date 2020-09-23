import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NewitemRoutingModule } from './newitem-routing.module';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ItemSearchComponent } from './item-search/item-search.component';

@NgModule({
  declarations: [IndexComponent, ViewComponent, CreateComponent, EditComponent, ItemSearchComponent],
  imports: [
    CommonModule,
    NewitemRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class NewitemModule { }
