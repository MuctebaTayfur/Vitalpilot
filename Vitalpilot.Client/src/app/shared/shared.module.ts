import { NgModule } from "@angular/core";
import { MaterialModule } from "./material.module";
import { BaseContentWithSidenavComponent } from "./base-content-with-sidenav/base-content-with-sidenav.component";
import { FooterComponent } from "./footer/footer.component";
import { HeaderComponent } from "../pages/main/header/header.component";
import { AppRoutingModule } from "../app-routing.module";

@NgModule({
    exports:[MaterialModule,
        HeaderComponent,
        FooterComponent
    ],
    declarations:[BaseContentWithSidenavComponent,
        FooterComponent,
        HeaderComponent,
    ],
    imports:[MaterialModule,
        AppRoutingModule
    ]
})
export class SharedModule{}