import { RouterModule, Routes } from "@angular/router";
import { AppointmentsComponent } from "./appointments.component";
import { AppointmentListComponent } from "./components/appointment-list/appointment-list.component";
import { NgModule } from "@angular/core";
import { AppointmentCreateComponent } from "./components/appointment-create/appointment-create.component";


const routes: Routes = [
    {
        path: '',
        component: AppointmentsComponent,
        children: [
            {
                path: '',
                pathMatch: 'full',
                redirectTo: 'list',
            },
            {
                path: 'list',
                component: AppointmentListComponent
            },
            {
                path: 'create',
                component: AppointmentCreateComponent
            }
        ]
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class AppointmentsRoutingModule{}