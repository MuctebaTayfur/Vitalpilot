import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import { ReportsComponent } from "./reports.component";
import { ReportListComponent } from "./components/report-list/report-list.component";


const routes: Routes = [
    {
        path: "",
        component: ReportsComponent,
        children: [
            {
                path: '',
                pathMatch: 'full',
                redirectTo: 'list',
            },
            {
                path: "list",
                component: ReportListComponent
            }
        ]
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class ReportsRoutingModule{}