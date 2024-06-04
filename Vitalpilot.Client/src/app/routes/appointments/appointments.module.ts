import { NgModule } from "@angular/core";
import { AppointmentsComponent } from "./appointments.component";
import { SharedModule } from "src/app/shared/shared.module";
import { AppointmentsRoutingModule } from "./appointments-routing.module";
import { AppointmentListComponent } from "./components/appointment-list/appointment-list.component";

@NgModule({
    declarations:[AppointmentsComponent,AppointmentListComponent],
    imports:[SharedModule,AppointmentsRoutingModule],
    exports:[AppointmentsComponent]
})
export class AppointmentsModule{
  
}