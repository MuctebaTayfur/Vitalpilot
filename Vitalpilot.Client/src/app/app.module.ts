import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home/home.component';
import { DoctorsComponent } from './pages/doctors/doctors.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DoctorsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
