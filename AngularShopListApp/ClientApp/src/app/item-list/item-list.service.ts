import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Item } from './item';

@Injectable({
  providedIn: 'root'
})
export class ItemListService {

  private apiURL = "https://localhost:44341/api";

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }


  constructor(private httpClient: HttpClient) { }


  getAll(): Observable<Item[]> {
    return this.httpClient.get<Item[]>(this.apiURL + '/ItemsModel/')
      .pipe(
        catchError(this.errorHandler)
      )
  }

  create(item): Observable<Item> {
    return this.httpClient.post<Item>(this.apiURL + '/ItemsModel/', JSON.stringify(item), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      )
  }

  find(id): Observable<Item> {
    return this.httpClient.get<Item>(this.apiURL + '/ItemsModel/' + id)
      .pipe(
        catchError(this.errorHandler)
      )
  }

  update(id, post): Observable<Item> {
    return this.httpClient.put<Item>(this.apiURL + '/ItemsModel/' + id, JSON.stringify(post), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      )
  }

  delete(id) {
    return this.httpClient.delete<Item>(this.apiURL + '/ItemsModel/' + id, this.httpOptions)
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
