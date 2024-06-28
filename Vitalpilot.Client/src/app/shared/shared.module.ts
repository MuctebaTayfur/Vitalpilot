import { NgModule } from "@angular/core";
import { MaterialModule } from "./material.module";
import { BaseContentWithSidenavComponent } from "./base-content-with-sidenav/base-content-with-sidenav.component";
import { FooterComponent } from "./footer/footer.component";
import { HeaderComponent } from "../pages/main/header/header.component";
import { RouterModule } from "@angular/router";
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
    exports: [MaterialModule,
        CommonModule,
        HeaderComponent,
        FooterComponent,
        BaseContentWithSidenavComponent
    ],
    declarations: [BaseContentWithSidenavComponent,
        FooterComponent,
        HeaderComponent,
    ],
    imports: [MaterialModule,RouterModule,CommonModule,HttpClientModule
    ]
})
export class SharedModule { }