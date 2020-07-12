import { ClientparService } from './Components/services/clientpar.service';
import { FormModule } from './pages/ui/form/form.module';
import { ClientRoutingModule } from './components/clients-par/client-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, Component } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ErrorInterceptor } from './core/helpers/error.interceptor';
import { JwtInterceptor } from './core/helpers/jwt.interceptor';
import { FakeBackendProvider } from './core/helpers/fake-backend';
import { LayoutsModule } from './layouts/layouts.module';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientsParComponent } from './components/clients-par/clients-par.component';
import { ClientsProComponent } from './components/clients-pro/clients-pro.component';
import { CommandesComponent } from './components/commandes/commandes.component';
import { LivreursComponent } from './components/livreurs/livreurs.component';
import { ResponsablesComponent } from './components/responsables/responsables.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AddClientComponent } from './components/add-client/add-client.component';
import { AddClientProComponent } from './components/add-client-pro/add-client-pro.component';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule } from '@angular/forms'
import { FlatpickrModule } from 'angularx-flatpickr';





import { GestureConfig } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { from } from 'rxjs';
import { ClientdireDirective } from './components/clients-pro/clientdire.directive';


@NgModule({
  declarations: [
    AppComponent,
    ClientsParComponent,
    ClientsProComponent,
    CommandesComponent,
    LivreursComponent,
    ResponsablesComponent,
    AddClientComponent,
    AddClientProComponent,
    ClientdireDirective,


  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    LayoutsModule,
    AppRoutingModule,
    FontAwesomeModule,
    ClientRoutingModule,
    FormsModule,
    FlatpickrModule.forRoot(),
    NgSelectModule








  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },


    // provider used to create fake backend
    FakeBackendProvider,

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
