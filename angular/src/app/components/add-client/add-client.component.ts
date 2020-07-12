import { Component, OnInit, EventEmitter } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { ClientparService } from '../services/clientpar.service';



@Component({
  selector: 'addclient',
  templateUrl: './add-client.component.html',
  styleUrls: ['./add-client.component.scss']
})
export class AddClientComponent implements OnInit {

  client = {
    idclpar: 0,
    nom: '',
    prenom: '',
    dtn: '',
    adresse: '',
    tel: '',
    idVille: 0,
    email: '',
    mdp: '',
  };

  validationform: FormGroup; // bootstrap validation form
  tooltipvalidationform: FormGroup; // bootstrap tooltip validation form
  basicFormvalidation: FormGroup; // basic form validation


  typeValidationForm: FormGroup; // type validation form
  rangeValidationForm: FormGroup; // range validation form
  // Form submition
  submit: boolean;
  formsubmit: boolean;
  basicsubmit: boolean;
  typesubmit: boolean;
  rangesubmit: boolean;
  horizontalsubmit: boolean;

  breadCrumbItems: Array<{}>;
  color: string;
  defaultColor: string;
  componentcolor: string;
  inlineColor: string;

  selectValue: string[];
  dropDownList: any[];
  selectedItem = new EventEmitter<any>();
  constructor(public formBuilder: FormBuilder, private clpar: ClientparService) {


  }
  ngOnInit(): void {
    this.basicFormvalidation = this.formBuilder.group({
      user: ['', [Validators.required, Validators.pattern('[a-zA-Z0-9]+')]],
      email: ['', [Validators.required, Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$')]],
      password: ['', [Validators.required, Validators.minLength(6)]],

    });


    //the call of the function of the api to get the ville 
    this.methodAPIToGetVilles()


  }










  //the methode get ville
  methodAPIToGetVilles() {
    this.clpar.getville()
      .subscribe(s => {
        this.dropDownList = s as any;

      });
  }

  //methode to get the value off the idville in the option
  getidville(id: any): void {
    this.client.idVille = id;
  }

  curUser: any = this.client[0];



  //the methode post  = ajouter un client particuluer
  addclientpar() {
    console.log(this.client);
    this.clpar.Ajouter(this.client)
      .subscribe(response => console.log(response));
  }



}
