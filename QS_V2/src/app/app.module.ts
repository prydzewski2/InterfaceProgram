import {LOCALE_ID, NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicRouteStrategy } from '@ionic/angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {LocationStrategy, PathLocationStrategy, registerLocaleData} from "@angular/common";
import localePl from '@angular/common/locales/pl';
import {CoreModule} from "../core/core.module";
import {AlertService} from "../core/services/common/alert-service";
import {NgxChildProcessModule} from "ngx-childprocess";

registerLocaleData(localePl);
@NgModule({
  declarations: [AppComponent],
  entryComponents: [],
  imports: [
    BrowserModule,
    CoreModule,
    AppRoutingModule,
    NgxChildProcessModule
  ],
  providers: [
    AlertService,
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy },
    { provide: LocationStrategy, useClass: PathLocationStrategy },
    { provide: LOCALE_ID, useValue: 'pl'}
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
