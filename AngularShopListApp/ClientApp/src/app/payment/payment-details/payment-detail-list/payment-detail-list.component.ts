
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetail } from '../../shared/payment-detail.model';
import { PaymentDetailService } from '../../shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail-list',
  templateUrl: './payment-detail-list.component.html',
  styles: []
  
})
export class PaymentDetailListComponent implements OnInit {
  
  constructor(public service: PaymentDetailService,
    private toastr: ToastrService) { }
   paymentdetails: PaymentDetail[] = [];
   
   
  ngOnInit(): void {
    this.service.getAll().subscribe((data: PaymentDetail[])=>{
      this.paymentdetails= data;
      console.log(this.paymentdetails);
    })  
  }

  
  populateForm(paymentdetails: PaymentDetail) {
    this.service.formData = Object.assign({},paymentdetails);
    this.service.formData = paymentdetails;
  }

  onDelete(pmId) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deletePaymentDetail(pmId)
        .subscribe(res => {
          this.service.getAll();
          this.toastr.warning('Deleted successfully', 'Payment Detail Register');
        },
          err => {
            console.log(err);
          })
    }
  }
  


}
