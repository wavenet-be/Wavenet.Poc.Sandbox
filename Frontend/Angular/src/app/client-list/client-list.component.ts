import { Component } from '@angular/core';

import { clients } from '../clients';
import {ClientService} from '../../services/client.service';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.css']
})
export class ClientListComponent {

  clients:any[];

  constructor(private clientService: ClientService)
  {
    this.clients = this.clientService.getClients();
  }

  
}


/*
Copyright Google LLC. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/