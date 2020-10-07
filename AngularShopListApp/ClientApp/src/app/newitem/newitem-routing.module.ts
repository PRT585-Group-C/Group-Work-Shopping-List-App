  import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';
import { ItemSearchComponent } from '../newitem/item-search/item-search.component'

const routes: Routes = [
  { path: 'newitem', redirectTo: 'newitem/index', pathMatch: 'full'},
  { path: 'newitem/index', component: IndexComponent },
  { path: 'newitem/:newiemId/view', component: ViewComponent },
  { path: 'newitem/create', component: CreateComponent },
  { path: 'newitem/:newiemId/edit', component: EditComponent }, 
  { path: 'newitem/item-search', component: ItemSearchComponent },
  { path: 'newitem/:postId/edit', component: EditComponent } 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class NewitemRoutingModule { }
