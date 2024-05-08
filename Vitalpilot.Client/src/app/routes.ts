import { Routes } from "@angular/router";
import { LoginComponent } from "./pages/login/login.component";
import { MainComponent } from "./pages/main/main.component";

const routes: Routes = [
    { path: 'login', component: LoginComponent },
    {
        path: '', component: MainComponent, children: [
            {
                path: 'my-appointments', loadChildren: () =>
                    import('./routes/appointments/appointments.module').then(x => x.AppointmentsModule)
            },
            {
                path: 'my-diseases', loadChildren: () =>
                    import('./routes/diseases/diseases.module').then(x => x.DiseasesModule)
            },
            {
                path: 'my-reports', loadChildren: () =>
                    import('./routes/prescriptions/prescriptions.module').then(x => x.PrescriptionsModule)
            },
            {
                path: 'my-prescriptions', loadChildren: () =>
                    import('./routes/reports/reports.module').then(x => x.ReportsModule)
            },


        ]
    }
]
export default routes;
