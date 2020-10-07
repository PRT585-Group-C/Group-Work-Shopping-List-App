import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PaymentRoutingModule } from './payment-routing.module';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { PaymentDetailComponent } from './payment-details/payment-detail/payment-detail.component';
import { PaymentDetailListComponent } from './payment-details/payment-detail-list/payment-detail-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
  declarations: [PaymentDetailsComponent, PaymentDetailComponent, PaymentDetailListComponent],
  imports: [
    CommonModule,
    PaymentRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule
  ],
  })
export class PaymentModule { }
