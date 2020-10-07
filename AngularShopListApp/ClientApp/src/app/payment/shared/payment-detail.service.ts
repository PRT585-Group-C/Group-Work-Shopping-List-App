import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import { HttpClient } from  "@angular/common/http";
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class PaymentDetailService {
  formData: PaymentDetail= {
    CVV: null,
    CardNumber: null,
    CardOwnerName: null,
    ExpirationDate: null,
    PMId: null
  };


  readonly rootURL = 'https://localhost:44341/api';
  list : PaymentDetail[];
  
  constructor(private http: HttpClient) { }
  
postPaymentDetail(formData: PaymentDetail){
  return this.http.post(this.rootURL + '/PaymentDetail',this.formData);
 }

 
  getAll(): Observable<PaymentDetail[]> {
    console.log('getAll service')
    return this.http.get<PaymentDetail[]>(this.rootURL + '/PaymentDetail')
      .pipe(
        catchError(this.errorHandler)
      )
  }
  errorHandler(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
  

  //put and delete
  putPaymentDetail() {
    return this.http.put(this.rootURL + '/PaymentDetail/'+ this.formData.PMId, this.formData);
  }
  deletePaymentDetail(id) {
    return this.http.delete(this.rootURL + '/PaymentDetail/'+ id);
  }


  
 
}





