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
  horizontalFormValidation: FormGroup; // horizontal form validation

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
  ville: any[];
  // Select2 Dropdown
  selectValue: string[];
  origVilles: any[] = [];
  dropDownList: any[];
  selectedItem = new EventEmitter<any>();
  constructor(public formBuilder: FormBuilder, private clpar: ClientparService) {


  }
  ngOnInit(): void {
    this.basicFormvalidation = this.formBuilder.group({
      user: ['', [Validators.required, Validators.pattern('[a-zA-Z0-9]+')]],
      email: ['', [Validators.required, Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$')]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmpwd: ['', Validators.required],
    }, {
      validator: MustMatch('password', 'confirmpwd'),
    });

    function MustMatch(controlName: string, matchingControlName: string) {
      return (formGroup: FormGroup) => {
        const control = formGroup.controls[controlName];
        const matchingControl = formGroup.controls[matchingControlName];

        if (matchingControl.errors && !matchingControl.errors.mustMatch) {
          return;
        }

        if (control.value !== matchingControl.value) {
          matchingControl.setErrors({ mustMatch: true });
        } else {
          matchingControl.setErrors(null);
        }
      };
    }


    // Select dropdown value
    // tslint:disable-next-line: max-line-length
    // this.clpar.getville()
    //   .subscribe(response => this.dropDownList = response as any);


    this.methodAPIToGetVilles()


  }











  methodAPIToGetVilles() {
    this.clpar.getville()
      .subscribe(s => {
        this.dropDownList = s as any;
        this.origVilles = s as any;
      });
  }

  filterVilles(str: string, ) {
    if (typeof str === 'string') {
      this.dropDownList = this.origVilles.filter(a => a.toLowerCase()
        .startsWith(str.toLowerCase()));
      this.client.idVille = this.dropDownList as any;

      var valueoption = document.getElementById("hh");
      valueoption.options[valueoption.SelectedIndex]



    }
    console.log(this.dropDownList);
  }


  addclientpar() {
    console.log(this.client);
    this.clpar.Ajouter(this.client)
      .subscribe(response => console.log(response));
  }



}
