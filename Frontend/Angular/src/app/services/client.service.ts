import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ClientService {

  constructor(private http: HttpClient) {
   }

  getClients() {
    return this.http.get('https://localhost:44350/api/client/list');
  }

  getClient(clientId: number) {
    return this.http.get('https://localhost:44350/api/client/' + clientId);
  }

}