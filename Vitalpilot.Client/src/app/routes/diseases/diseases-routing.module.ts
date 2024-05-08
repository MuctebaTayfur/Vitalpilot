import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { DiseasesComponent } from "./diseases.component";
import { DiseaseListComponent } from "./components/disease-list/disease-list.component";


const routes: Routes = [
    {
        path: '',
        component: DiseasesComponent,
        children: [
            {
                path: '',
                pathMatch: 'full',
                redirectTo: 'list',
            },
            {
                path: 'list',
                component: DiseaseListComponent
            }
        ]
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class DiseasesRoutingModule{}