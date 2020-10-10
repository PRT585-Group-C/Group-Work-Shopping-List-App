import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';


const routes: Routes = [{ path: 'itemlist', redirectTo: 'itemlist/index', pathMatch: 'full' },
  { path: 'itemlist/index', component: IndexComponent },
  { path: 'itemlist/:itemlistId/view', component: ViewComponent },
  { path: 'itemlist/create', component: CreateComponent },];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ItemlistRoutingModule { }
