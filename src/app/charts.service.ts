import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ChartsService {
  private apiUrl = 'http://localhost:5102/api';
  constructor(private http: HttpClient) { }

  getChartData(Type: string): Observable<any> {
    const url = `${this.apiUrl}/charts?type=${Type}`; 
    return this.http.get<any>(url);
  }

}
