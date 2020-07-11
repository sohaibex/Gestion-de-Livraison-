
import { Component, OnInit } from '@angular/core';
import { JsonPipe } from '@angular/common';
import { ClientparService } from '../services/clientpar.service';

@Component({
  selector: 'clientpar',
  templateUrl: './clients-par.component.html',
  styleUrls: ['./clients-par.component.scss']
})
export class ClientsParComponent implements OnInit {
  clientp: any[] = [];
  constructor(private cpars: ClientparService) { }

  getclientpar() {
    this.cpars.getclientpro().subscribe(clientp => {
      this.clientp = clientp as any
    });
  }

  ngOnInit(): void {
    this.getclientpar();
  }

}
