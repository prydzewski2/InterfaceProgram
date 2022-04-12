/* eslint-disable no-console */
import { Injectable } from '@angular/core';
import {TimeService} from './time.service';
import {environment} from "../../../environments/environment";
import {Subject} from "rxjs";

@Injectable({ providedIn: 'root' })
export class LogService {
  constructor(private timeService: TimeService) { }

  info(message: string, object: any = null): void {
    if(environment.configuration.logger) {
      if(object != null){
        console.info(`[INF] [${this.timeService.now()}] ${message}`, JSON.stringify(object));
      }else{
        console.info(`[INF] [${this.timeService.now()}] ${message}`);
      }
    }
  }

  warn(message: string, object: any = null): void {
    if(environment.configuration.logger) {
      if(object != null){
        console.warn(`[WRN] [${this.timeService.now()}] ${message}`, JSON.stringify(object));
      }else{
        console.warn(`[WRN] [${this.timeService.now()}] ${message}`);
      }
    }
  }

  error(message: string, object: any = null): void {
    if(environment.configuration.logger) {
      if(object != null){
        console.error(`[ERR] [${this.timeService.now()}] ${message}`, JSON.stringify(object));
      }else{
        console.error(`[ERR] [${this.timeService.now()}] ${message}`);
      }
    }
  }
}
