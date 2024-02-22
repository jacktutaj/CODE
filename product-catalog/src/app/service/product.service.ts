import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, tap } from 'rxjs';
import { Product } from '../product';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private baseUrl = 'http://localhost:5170/products';

  constructor(private httpClient: HttpClient) {}

  private _refreshRequired = new Subject<void>();

  get refreshRequired() {
    return this._refreshRequired;
  }

  public getProducts(): Observable<any> {
    return this.httpClient.get(this.baseUrl);
  }

  public addProduct(product: Product): Observable<object> {
    return this.httpClient.post(this.baseUrl, product).pipe(
      tap(() => {
        this.refreshRequired.next();
      })
    );
  }
}
