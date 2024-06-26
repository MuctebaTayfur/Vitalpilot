import { NgModule } from "@angular/core";
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatCardModule} from '@angular/material/card';
import {MatTableModule} from '@angular/material/table';

@NgModule({
    exports: [
        MatToolbarModule,
        MatButtonModule,
        MatDividerModule,
        MatIconModule,
        MatSidenavModule,
        MatCardModule,
        MatTableModule

    ]
})

export class MaterialModule { }