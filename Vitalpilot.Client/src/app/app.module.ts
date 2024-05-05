import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { MainComponent } from './pages/main/main.component';
import { LoginComponent } from './pages/login/login.component';
import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { SharedModule } from './shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppointmentsComponent } from './routes/appointments/appointments.component';
import { DiseasesComponent } from './routes/diseases/diseases.component';
import { ReportsComponent } from './routes/reports/reports.component';
import { PrescriptionsComponent } from './routes/prescriptions/prescriptions.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    LoginComponent,
    DiseasesComponent,
    ReportsComponent,
    PrescriptionsComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    SharedModule,
    BrowserAnimationsModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
