import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PaymentDetailListComponent } from './payment-details/payment-detail-list/payment-detail-list.component';
import { PaymentDetailComponent } from './payment-details/payment-detail/payment-detail.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';


const routes: Routes = [
  { path: 'payment', redirectTo: 'payment/payment-details', pathMatch: 'full'},
  { path: 'payment/payment-details', component: PaymentDetailsComponent},
  { path: 'payment/payment-detail', component: PaymentDetailComponent},
  { path: 'payment/payment-detail-list', component: PaymentDetailListComponent},
  { path: 'payment/:payment-details/payment-detail-list', component: PaymentDetailListComponent },
  
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PaymentRoutingModule { }
