import {Injectable, OnDestroy } from '@angular/core'
import {Observable, Subject, Subscription } from "rxjs";
import { Device } from 'src/core/models/device';
import {Telemetries, TelemetryType, TelemetryValues } from 'src/core/models/telemetry';
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

  public saveData(): Promise<void> {
    return new Promise(async (resolve, reject) => {
      let cmd = 'S,';

      cmd += Array.from(this.device.telemetry.values()).filter(i => i.type === TelemetryType.Configuration && i.index >= 5)
        .sort((a, b) => a.index - b.index).map(i => i.getValue()).join(',');

      await this.serialPortService.write(cmd);
    });
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

      if (value.getValue() != valueToSet) {
        value.setValue(valueToSet);
        changed = true;
      }
    });

    if (changed) {
      this.onChangeSubject.next(this.device.telemetry);
    }
  }
}
