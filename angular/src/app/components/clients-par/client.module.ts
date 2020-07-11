import { HttpClientModule } from '@angular/common/http';
import { AddClientComponent } from './../add-client/add-client.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ClientRoutingModule } from './client-routing.module';
import { UIModule } from 'src/app/shared/ui/ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CKEditorModule } from '@ckeditor/ckeditor5-angular';
import { NgxMaskModule } from 'ngx-mask';
import { FlatpickrModule } from 'angularx-flatpickr';
import { DropzoneModule } from 'ngx-dropzone-wrapper';
import { NgSelectModule } from '@ng-select/ng-select';
import { ColorPickerModule } from 'ngx-color-picker';
import { ArchwizardModule } from 'angular-archwizard';
import { FormRoutingModule } from 'src/app/pages/ui/form/form-routing.module';
import { ValidationComponent } from 'src/app/pages/ui/form/validation/validation.component';
import { ClientparService } from '../services/clientpar.service';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ClientRoutingModule,
    FontAwesomeModule,
    CommonModule,
    UIModule,
    FormsModule,
    ReactiveFormsModule,
    CKEditorModule,
    NgxMaskModule.forRoot(),
    FlatpickrModule.forRoot(),
    DropzoneModule,
    NgSelectModule,
    ColorPickerModule,
    ArchwizardModule,
    FormRoutingModule,
    HttpClientModule

  ],

  providers: [ClientparService]

})
export class ClientModule { }
