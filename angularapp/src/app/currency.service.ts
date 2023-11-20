import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CurrencyService {
  private apiUrl = 'http://localhost:5205/api/currency';

  constructor(private http: HttpClient) {}

  getCurrencyData(year: number): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${year}`);
  }
}
