import { NgModule } from "@angular/core";
import { SharedModule } from "src/app/shared/shared.module";
import { PrescriptionsComponent } from "./prescriptions.component";
import { PrescriptionsRoutingModule } from "./prescriptions-routing.module";

@NgModule({
    declarations:[PrescriptionsComponent],
    imports:[SharedModule,PrescriptionsRoutingModule],
    exports:[PrescriptionsComponent]
})
export class PrescriptionsModule{}