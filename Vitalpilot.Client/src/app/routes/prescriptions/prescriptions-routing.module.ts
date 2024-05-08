import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { PrescriptionsComponent } from "./prescriptions.component";
import { PrescriotionListComponent } from "./components/prescriotion-list/prescriotion-list.component";


const routes: Routes = [
    {
        path: '',
        component: PrescriptionsComponent,
        children: [
            {
                path: '',
                pathMatch: 'full',
                redirectTo: 'list',
            },
            {
                path: 'list',
                component: PrescriotionListComponent
            }
        ]
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class PrescriptionsRoutingModule{}