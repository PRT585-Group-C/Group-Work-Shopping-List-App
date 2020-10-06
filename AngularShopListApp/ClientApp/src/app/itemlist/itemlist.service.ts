import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Itemlist } from './itemlist';
@Injectable({
  providedIn: 'root'
})
export class ItemlistService {

  private apiURL = "https://localhost:44341/api";

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<Itemlist[]> {
    return this.httpClient.get<Itemlist[]>(this.apiURL + '/ItemsList/')
      .pipe(
        catchError(this.errorHandler)
      )
  }

  create(post): Observable<Itemlist> {
    return this.httpClient.post<Itemlist>(this.apiURL + '/ItemsList/', JSON.stringify(post), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      )
  }

  find(id): Observable<Itemlist> {
    return this.httpClient.get<Itemlist>(this.apiURL + '/ItemsList/' + id)
      .pipe(
        catchError(this.errorHandler)
      )
  }

  delete(id) {
    return this.httpClient.delete<Itemlist>(this.apiURL + '/ItemsList/' + id, this.httpOptions)
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
}
