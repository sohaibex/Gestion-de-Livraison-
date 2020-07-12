import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClientparService {
  clientp: any[] = [];
  private url = 'http://localhost:34614/api/'
  constructor(private http: HttpClient) {
  }

  getclientpro() {
    return this.http.get(this.url + 'ClientPars');
  }

  Ajouter(client) {
    return this.http.post(this.url + 'ClientPars', client);
  }

  getville() {
    return this.http.get('http://localhost:34614/api/Villes');
  }


}
