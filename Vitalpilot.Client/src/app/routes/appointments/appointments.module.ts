import { NgModule } from "@angular/core";
import { AppointmentsComponent } from "./appointments.component";
import { SharedModule } from "src/app/shared/shared.module";
import { AppointmentsRoutingModule } from "./appointments-routing.module";

@NgModule({
    declarations:[AppointmentsComponent],
    imports:[SharedModule,AppointmentsRoutingModule],
    exports:[AppointmentsComponent]
})
export class AppointmentsModule{}