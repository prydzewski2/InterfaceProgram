import { Injectable } from '@angular/core';
import * as moment from 'moment';

@Injectable({
  providedIn: 'root'
})
export class TimeService {

  public now(): string {
    return moment(new Date()).format('HH:mm:ss.SSS');
  }

  public timestamp(): number {
    return Math.round(new Date().getTime() / 1000);
  }
}
