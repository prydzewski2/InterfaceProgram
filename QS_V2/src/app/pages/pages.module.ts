import { NgModule } from '@angular/core';

import { PagesPageRoutingModule } from './pages-routing.module';
import { PagesPage } from './pages.page';
import {CoreModule} from "../../core/core.module";
import {HomePage} from "./home/home.page";
import { ConfigurationPage } from './configuration/configuration';

@NgModule({
  imports: [
    CoreModule,
    PagesPageRoutingModule
  ],
  declarations: [
    PagesPage,
    HomePage,
    ConfigurationPage
  ]
})
export class PagesPageModule {}
