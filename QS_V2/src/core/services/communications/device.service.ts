import {Injectable, OnDestroy } from '@angular/core'
import {Observable, Subject, Subscription } from "rxjs";
import { Device } from 'src/core/models/device';
import {Telemetries, TelemetryValues } from 'src/core/models/telemetry';
import { SerialPortService } from "./serial-port.service";

@Injectable({
  providedIn: 'root'
})
export class DeviceService implements OnDestroy{
  private dataStreamSubscriber: Subscription;
  private device?: Device;
  private onChangeSubject: Subject<Telemetries> = new Subject<Telemetries>();

  constructor(private serialPortService: SerialPortService) {
    this.device = this.serialPortService.connectedDevice();
    this.dataStreamSubscriber = serialPortService.dataStream().subscribe((data) =>
      this.handleDataStream(data)
    );
  }

  public connectedDevice(): Device | undefined  {
    return this.device;
  }

  public onChange(): Observable<Telemetries> {
    return this.onChangeSubject;
  }

  ngOnDestroy(): void {
        if (this.dataStreamSubscriber) {
          this.dataStreamSubscriber.unsubscribe();
        }
    }

  private handleDataStream(data: string): void {
    const device = this.device;
    if (!data || !device) {
      return;
    }

    const values = data.split(',');
    const telemetries = Array.from(device.telemetry.values()).filter(i => i.type === values[0]);

    if (!telemetries.length) {
      return;
    }

    let changed = false;
    telemetries.forEach(i => {
      const value = device.telemetry.get(i.valueType);
      const valueToSet = values[i.index];

      if (value.value != valueToSet) {
        value.value = valueToSet;
        changed = true;
      }
    });

    if (changed) {
      this.onChangeSubject.next(this.device.telemetry);
    }
  }
}
