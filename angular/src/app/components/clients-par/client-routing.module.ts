import { ClientsProComponent } from './../clients-pro/clients-pro.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ClientsParComponent } from './clients-par.component';
import { AddClientComponent } from '../add-client/add-client.component';


const routes: Routes = [
  { path: 'clientpar', component: ClientsParComponent },
  { path: 'clientpro', component: ClientsProComponent },
  { path: 'addclient', component: AddClientComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientRoutingModule { }
