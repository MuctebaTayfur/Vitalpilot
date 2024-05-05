import { NgModule } from "@angular/core";
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
    exports: [
        MatToolbarModule,
        MatButtonModule,
        MatDividerModule,
        MatIconModule

    ]
})

export class MaterialModule { }