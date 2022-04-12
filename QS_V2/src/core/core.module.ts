import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { RouterModule } from '@angular/router';
import {TimeService} from './services/common/time.service';
import {LogService} from './services/common/log.service';
// import {LoadingService} from "./services/common/loading.service";
import {AlertService} from "./services/common/alert-service";
import { SerialPortService } from './services/communications/serial-port.service';

@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    IonicModule.forRoot({ animated: false }),
    RouterModule
  ],
  exports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    IonicModule
  ],
  providers: [
    AlertService,
    // LoadingService,
    LogService,
    SerialPortService,
    TimeService
  ]
})
export class CoreModule {
}
