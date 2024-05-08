import { NgModule } from "@angular/core";
import { PreloadAllModules, RouterModule } from "@angular/router";
import routes from "./routes";


@NgModule({
    imports: [RouterModule.forRoot(routes, {
        useHash: false,
        enableTracing: false,
        initialNavigation: 'disabled',
        preloadingStrategy: PreloadAllModules,
        onSameUrlNavigation: 'reload'

    })],
    exports: [RouterModule]
})
export class AppRoutingModule { }