import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OfertaService {

  baseURL = 'http://localhost:5000/api/oferta/'

  constructor(private http: HttpClient) { }

  getOfertas(){
    return this.http.get(this.baseURL);
  }

}
