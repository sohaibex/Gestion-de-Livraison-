import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CommandesService {
  private url = 'http://localhost:34614/api/Commandes';
  constructor(private http: HttpClient) { }

  getcommandes() {
    return this.http.get(this.url);
  }
}
