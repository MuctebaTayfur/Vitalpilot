import { NgModule } from "@angular/core";
import { SharedModule } from "src/app/shared/shared.module";
import { ReportsComponent } from "./reports.component";
import { ReportsRoutingModule } from "./reports-routing.module";

@NgModule({
    declarations:[ReportsComponent],
    imports:[SharedModule,ReportsRoutingModule],
    exports:[ReportsComponent]
})
export class ReportsModule{}