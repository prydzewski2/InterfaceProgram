import { Component, ChangeDetectorRef } from '@angular/core';
import { FormBuilder, Validators, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ViewWillEnter } from '@ionic/angular';
import {Telemetries, TelemetryValueType } from 'src/core/models/telemetry';
import { AlertService } from 'src/core/services/common/alert-service';
import { DeviceService } from 'src/core/services/communications/device.service';
import { SerialPortService } from 'src/core/services/communications/serial-port.service';
import {Device} from "../../../core/models/device";
import {LogService} from "../../../core/services/common/log.service";

@Component({
  selector: 'app-configuration',
  templateUrl: 'configuration.html',
  styleUrls: ['configuration.scss'],
  providers: [DeviceService]
})
export class ConfigurationPage implements ViewWillEnter {
  public types = TelemetryValueType;
  public values: Telemetries = new Map([]);

  constructor(
    private changeDetectorRef: ChangeDetectorRef,
    private readonly serialPortService: SerialPortService,
    public loggerService: LogService,
    private router: Router,
    public deviceService: DeviceService,
    private readonly alertService: AlertService){}

  public async ionViewWillEnter(): Promise<void> {
    if (!this.device?.isConnected) {
      await this.router.navigate(['/']);
    } else {
      this.values = new Map([...this.device.telemetry]);
      this.deviceService.onChange().subscribe((t) => {
        this.values = new Map([...t]);
        this.changeDetectorRef.detectChanges();
      });
    }
  }

  public getValue(key: TelemetryValueType): string {
    return this.values.get(key)?.value;
  }

  public get device(): Device | undefined {
    return this.deviceService.connectedDevice();
  }

  public async read() {
    await this.serialPortService.write('R');
  }
}
