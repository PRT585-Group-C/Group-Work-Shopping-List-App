import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';

const routes: Routes = [
  { path: 'item_list', redirectTo: 'item_list/index', pathMatch: 'full' },
  { path: 'item_list/index', component: IndexComponent },
  { path: 'item_list/:itemId/view', component: ViewComponent },
  { path: 'item_list/create', component: CreateComponent },
  { path: 'item_list/:itemId/edit', component: EditComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ItemListRoutingModule { }
