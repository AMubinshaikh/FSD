
import { Injectable } from '@angular/core';

//import for observables
import { Observable, observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {
// inject httpClient
  constructor(private http: HttpClient) {

  }
  url='https://jsonplaceholder.typicode.com/users';
  //assign observables type: any
  product(): Observable < any > {
    return this.http.get(this.url);
  }
}


