import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetailService } from '../../shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styleUrls: ['./payment-detail.component.css']
})
export class PaymentDetailComponent implements OnInit {

  constructor(private service: PaymentDetailService,
    private toastr: ToastrService) { }

    ngOnInit() {
      this.resetForm();
    }

    resetForm(form?: NgForm) {
      if (form != null)
        form.form.reset();
      this.service.formData = {
        PMId: 0,
        CardOwnerName: '',
        CardNumber: '',
        ExpirationDate: '',
        CVV: ''
      }
    }
      
  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }
  
  insertRecord(form: NgForm) {
    this.service.postPaymentDetail(form.value).subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Payment Detail Register');
        //this.service.refreshList();
      },
      err => { console.log(err); }
    )
  }
    

  

}
