import { NgModule } from "@angular/core";
import { Routes } from "@angular/router";
import { LoginComponent } from "./pages/login/login.component";
import { MainComponent } from "./pages/main/main.component";
import { AppointmentsComponent } from "./routes/appointments/appointments.component";
import { DiseasesComponent } from "./routes/diseases/diseases.component";
import { ReportsComponent } from "./routes/reports/reports.component";
import { PrescriptionsComponent } from "./routes/prescriptions/prescriptions.component";
import { AppointmentsModule } from "./routes/appointments/appointments.module";

export const routes:Routes=[
    {path:'login',component:LoginComponent},
    {path:'',component:MainComponent,children:[
        {path:'my-appointments',component:AppointmentsModule},
        {path:'my-diseases',component:DiseasesComponent},
        {path:'my-reports',component:ReportsComponent},
        {path:'my-prescriptions',component:PrescriptionsComponent}
    ]}
 ]
