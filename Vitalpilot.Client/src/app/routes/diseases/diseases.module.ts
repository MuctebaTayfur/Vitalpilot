import { NgModule } from "@angular/core";
import { SharedModule } from "src/app/shared/shared.module";
import { DiseasesComponent } from "./diseases.component";
import { DiseasesRoutingModule } from "./diseases-routing.module";

@NgModule({
    declarations:[DiseasesComponent],
    imports:[SharedModule,DiseasesRoutingModule],
    exports:[DiseasesComponent]
})
export class DiseasesModule{}