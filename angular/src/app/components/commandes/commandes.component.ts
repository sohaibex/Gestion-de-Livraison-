import { CommandesService } from './../services/commandes.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'commandes',
  templateUrl: './commandes.component.html',
  styleUrls: ['./commandes.component.scss']
})
export class CommandesComponent implements OnInit {
  commandes: any[] = [];
  constructor(private cmd: CommandesService) { }

  getcommandes() {
    this.cmd.getcommandes()
      .subscribe(response => {
        this.commandes = response as any;
      })
  }
  ngOnInit(): void {
    this.getcommandes();
  }

}
